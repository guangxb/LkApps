using Apps.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Apps.Web.Core
{
    public class OrderIdentification
    {
        public static Dictionary<string,string> Distinguish(string code) {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            //if (code.IsSame("EMS") || code.IsSame("EYB") || code.IsSame("YDO"))
            //{
            //    dic["Code"] = "EMS";
            //    dic["Name"] = "EMS";
            //}
            //else {


            switch (code)
            {
                case "EMS": case "EYB": case "YDO": dic["Code"] = "EMS"; dic["Name"] = "EMS"; break;
                case "DBWL": dic["Code"] = "DBL"; dic["Name"] = "德邦物流"; break;
                case "POSTB": dic["Code"] = "YZPY"; dic["Name"] = "邮政平邮"; break;
                case "FAST": dic["Code"] = "FAST"; dic["Name"] = "快捷快递"; break;
                case "GTO": dic["Code"] = "GTO"; dic["Name"] = "国通快递"; break;
                case "HTKY": dic["Code"] = "HTKY"; dic["Name"] = "百世快递"; break;
                case "QFKD": dic["Code"] = "QFKD"; dic["Name"] = "全峰快递"; break;
                case "SF": case "SFH": dic["Code"] = "SF"; dic["Name"] = "顺丰快递"; break;
                case "STO": dic["Code"] = "STO"; dic["Name"] = "申通快递"; break;
                case "TTKDEX": dic["Code"] = "HHTT"; dic["Name"] = "天天快递"; break;
                case "UC": dic["Code"] = "UC"; dic["Name"] = "优速快递"; break;
                case "YTO": case "YTOD": dic["Code"] = "YTO"; dic["Name"] = "圆通快递"; break;
                case "YUNDA": dic["Code"] = "YD"; dic["Name"] = "韵达快递"; break;
                case "ZJS": dic["Code"] = "ZJS"; dic["Name"] = "宅急送"; break;
                case "ZTO": case "ZTOD": dic["Code"] = "ZTO"; dic["Name"] = "中通快递"; break;
                case "ZT": dic["Code"] = "LK"; dic["Name"] = "仓库自提"; break;
                case "WL": dic["Code"] = "LK"; dic["Name"] = "物流"; break;
                case "SFCT": dic["Code"] = "LK"; dic["Name"] = "自提转顺丰传统面单"; break;
                case "LKTO": dic["Code"] = "LK"; dic["Name"] = "虚拟承运商"; break;
                case "LKZP": dic["Code"] = "LK"; dic["Name"] = "临空配送"; break;
                default:
                    dic["Code"] = "LK"; dic["Name"] = "无匹配承运商";
                    break;
            }
            return dic;

        }
    }
}