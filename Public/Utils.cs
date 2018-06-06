using CCWin.SkinControl;
using System;
using System.Drawing;

namespace EsayCare.MES
{
    /// <summary>
    /// 助理类
    /// </summary>
	public class Utils
    {
        /// <summary>
        /// 将时间转化成中文常规格式
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public string DateTimeToZh(DateTime dt)
        {
            string temp = string.Empty;
            if (dt > DateTime.MinValue)
            {
                DateTime now = DateTime.Now;
                int dayofweek = (int)now.DayOfWeek;
                int days = (now - dt).Days;
                if (days < (dayofweek + 7))
                {
                    switch (days)
                    {
                        case 0:
                            temp = "今天";
                            break;
                        case 1:
                            temp = "昨天";
                            break;
                        case 2:
                            temp = "前天";
                            break;
                        default:
                            if (days >= dayofweek)
                                temp = "上";
                            switch ((int)dt.DayOfWeek)
                            {
                                case 0:
                                    temp += "周日";
                                    break;
                                case 1:
                                    temp += "周一";
                                    break;
                                case 2:
                                    temp += "周二";
                                    break;
                                case 3:
                                    temp += "周三";
                                    break;
                                case 4:
                                    temp += "周四";
                                    break;
                                case 5:
                                    temp += "周五";
                                    break;
                                case 6:
                                    temp += "周六";
                                    break;

                            }
                            break;
                    }
                    temp += dt.ToString(" HH:mm"); 
                }
                else
                {
                    temp = dt.ToString("dd号 HH:mm");
                }
            }
            return temp;
        }
    }

    public static class ColorHelper
    {
        public static Color MsgGreen = Color.FromArgb(255,30,200,100);
        public static Color MsgRed = Color.FromArgb(255, 230, 20, 30);
        public static Color MsgOrange = Color.FromArgb(255, 255, 130, 0);
        public static Color MsgGray = Color.FromArgb(255, 80, 80, 80);
    }


    public static class ButtonTheam
    {
        public static void OrangeButton(SkinButton btn)
        {
            btn.BaseColor = Color.FromArgb(255, 128, 0);
            btn.BorderColor = Color.FromArgb(255, 128, 0);
            btn.DownBaseColor = Color.FromArgb(192, 64, 0);
            btn.MouseBaseColor = Color.FromArgb(255, 192, 128);
        }
        public static void LightGrayButton(SkinButton btn)
        {
            btn.BaseColor = Color.LightGray;
            btn.BorderColor = Color.LightGray;
            btn.DownBaseColor = Color.Silver;
            btn.MouseBaseColor = Color.Gainsboro;
        }
    }
}
