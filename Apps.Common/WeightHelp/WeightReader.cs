using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace Apps.Common.WeightHelp
{
     /// <summary>
    /// 电子秤接口信息类，封装COM口数据
    /// </summary>
    public class WeightInformation
    {
        string _wdata;
        string _wunit;
        string _qdata;
        string _qunit;
        string _percentage;


        /// <summary>
        /// 获取或设置重量
        /// </summary>
        public string WData { get { return this._wdata; } set { this._wdata = value; } }
        /// <summary>
        /// 获取或设置重量单位
        /// </summary>
        public string WUnit { get { return this._wunit; } set { this._wunit = value; } }
        /// <summary>
        /// 获取或设置数量
        /// </summary>
        public string QData { get { return this._qdata; } set { this._qdata = value; } }
        /// <summary>
        /// 获取或设置数量单位
        /// </summary>
        public string QUnit { get { return this._qunit; } set { this._qunit = value; } }
        /// <summary>
        /// 获取或设置百分数
        /// </summary>
        public string Percentage { get { return this._percentage; } set { this._percentage = value; } }
    }

    /// <summary>
    /// 电子称数据读取类
    /// </summary>
    public class WeightReader : IDisposable
    {
        #region 字段、属性与构造函数
        
        int _speed = 30;
        
        static string WatchPortTitie = ConfigurationManager.AppSettings["WatchPort"].ToString();

        static SerialPort _sp = new SerialPort(WatchPortTitie, 9600, Parity.None, 8);
        public SerialPort sp = _sp;
        private static System.Timers.Timer updateDataTimer;
        public void StartWatchService()
        {
            updateDataTimer = new System.Timers.Timer();
            //定时器
            updateDataTimer.Interval = 1000;        //1秒执行一次
                                                         //事件委托
            updateDataTimer.Elapsed += new ElapsedEventHandler(TimeUpdateDataTimer_Elapsed);
            updateDataTimer.Enabled = true;
        }
        private void TimeUpdateDataTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            bool isRight= InitCom(WatchPortTitie);
            if (!isRight)
            {
                InitCom(WatchPortTitie);
            }
        }


        /// <summary>
        /// 获取或设置电脑取COM数据缓冲时间，单位毫秒
        /// </summary>
        public int Speed
        {
            get
            {
                return this._speed;
            }
            set
            {
                if (value < 30)
                    throw new Exception("串口读取缓冲时间不能小于30毫秒!");
                this._speed = value;
            }
        }

        public bool InitCom(string PortName)
        {
            return this.InitCom(PortName, 9600, 300);
        }

        /// <summary>
        /// 初始化串口
        /// </summary>
        /// <param name="PortName">数据传输端口</param>
        /// <param name="BaudRate">波特率</param>
        /// <param name="Speed">串口读数缓冲时间</param>
        /// <returns></returns>
        public bool InitCom(string PortName, int BaudRate, int Speed)
        {
            try
            {
                sp.ReceivedBytesThreshold = 10;
                sp.Handshake = Handshake.RequestToSend;
                sp.Parity = Parity.None;
                sp.ReadTimeout = 600;
                sp.WriteTimeout = 600;
                this.Speed = Speed;
                if (!sp.IsOpen)
                {
                    sp.Open();
                }
                return true;
            }
            catch
            {
                return false;
                //throw new Exception(string.Format("无法初始化串口{0}!", PortName));
            }
        }

        #endregion

        #region 串口数据读取方法
        public WeightInformation ReadInfo()
        {
            string src = this.ReadCom();
            //Console.WriteLine("src is:" + src);
            WeightInformation info = new WeightInformation();
            info.WData = src;
            //info.WData = this.DecodeWeightData(src);
            //info.WUnit = this.DecodeWeightUnit(src);
            //info.Percentage = this.DecodePercentage(src);
            //info.QData = this.DecodeQualityData(src);
            //info.QUnit = this.DecodeQualityUnit(src);

            return info;
        }
        /// <summary>
        /// 将COM口缓存数据全部读取
        /// </summary>
        /// <returns></returns>
        private string ReadCom()//返回信息 
        {
            if (this.sp.IsOpen)
            {
                Thread.Sleep(this._speed);
                
                byte[] buffer = new byte[sp.BytesToRead];

                string res = "";
                sp.Read(buffer, 0, buffer.Length);       //获取缓存区数据                 

                for (int i = 4; i > 1; i--)
                {
                    try
                    {
                        res = res + buffer[i].ToString("X2");
                    }
                    catch (Exception)
                    {

                        res = res + "00";
                    }
                    
                }
                int test = 0;
                try
                {
                    test = Convert.ToInt32(res);
                    res = (test * 0.001).ToString();
                }
                catch (Exception)
                {

                    res = (test * 0.001).ToString();
                }

                if (res == "")
                {
                    res = "0";
                    //throw new Exception("串口读取数据为空，参数设置是否正确!");
                }
                return res;
            }
            else
            {
                return "0";
            }           
        }
        #endregion

        #region  基本取数方法

        /// <summary>
        /// 从字符串中取值
        /// </summary>
        /// <param name="head">起始字符串</param>
        /// <param name="intervalLen">间隔位长度</param>
        /// <param name="valueLen">值长度</param>
        /// <param name="src">源字符串</param>
        /// <returns></returns>
        private string DecodeValue(string head, int intervalLen, int valueLen, string src)
        {
            int index = src.IndexOf(head);
            return src.Substring(index + intervalLen, valueLen);
        }
        /// <summary>
        /// 取重量
        /// </summary>
        /// <param name="srcString">源字符串</param>
        /// <returns></returns>
        private string DecodeWeightData(string srcString)
        {
            return this.DecodeValue("GS,", 3, 8, srcString);
        }
        /// <summary>
        /// 取重量单位
        /// </summary>
        /// <param name="srcString">源字符串</param>
        /// <returns></returns>
        private string DecodeWeightUnit(string srcString)
        {
            return this.DecodeValue("GS,", 12, 2, srcString);
        }
        /// <summary>
        /// 取百分数
        /// </summary>
        /// <param name="srcString">源字符串</param>
        /// <returns></returns>
        private string DecodePercentage(string srcString)
        {
            return this.DecodeValue("U.W.", 4, 14, srcString);
        }
        /// <summary>
        /// 取数量
        /// </summary>
        /// <param name="srcString">源字符串</param>
        /// <returns></returns>
        private string DecodeQualityData(string srcString)
        {
            return this.DecodeValue("PCS", 3, 9, srcString);
        }

        /// <summary>
        /// 取数量单位
        /// </summary>
        /// <param name="srcString">源字符串</param>
        /// <returns></returns>
        private string DecodeQualityUnit(string srcString)
        {
            return this.DecodeValue("PCS", 12, 3, srcString);
        }
        #endregion

        #region 释放所有资源
        public void Dispose()
        {
            if (sp != null && sp.IsOpen)
            {
                sp.Close();
            }
        }
        #endregion
    }
}
