using Apps.Models;

namespace Apps.IService
{
    public partial interface ISysConfigService
    {
        /// <summary>
        ///  读取配置文件
        /// </summary>
        SysConfigModel LoadConfig(string configFilePath);

        /// <summary>
        /// 读取客户端站点配置信息
        /// </summary>
        SysConfigModel LoadConfig(string configFilePath, bool isClient);


        /// <summary>
        ///  保存配置文件
        /// </summary>
        SysConfigModel SaveConifg(SysConfigModel model, string configFilePath);
    }
}
