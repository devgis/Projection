using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Test
{
    /// <summary>
    /// 2000坐标系
    /// vp:hsg
    /// create date:2015-12
    /// </summary>
    public class GSCoordConvertionClass_2000 : ProjectionConversion2, IProjectionConversion2
    {
        public GSCoordConvertionClass_2000()
        {
            this.a = 6378137M;           //2000椭球长半轴
            this.b = 6356752.3141M;      //2000椭球短半轴
            this.f = 1 / 298.257222101M;     //椭球扁率f
            this.e = 0.0818191910428M;       //第一偏心率
            this.e2 = 6.693421622966E-03M;   //椭球第一偏心率平方 e2
            this.e12 = 6.738525414683E-03M;  //椭球第二偏心率平方 e12
            this.c = 6399593.62586M;         //极点子午圈曲率半径 c
            this.p = 206264.806252992M;      //弧度秒=180*3600/pi
            this.pi = 3.1415926535M;
        }

    }
    /// <summary>
    /// 西安80坐标
    /// vp:hsg
    /// create date:2015-12
    /// </summary>
    public class GSCoordConvertionClass_Xian80 : ProjectionConversion2, IProjectionConversion2
    {
        public GSCoordConvertionClass_Xian80()
        {
            this.a = 6378140M;           //西安80椭球长半轴
            this.b = 6356755.29M;        //西安80椭球短半轴
            this.f = 1 / 298.257M;     //椭球扁率f
            this.e = 0.081819221455523M;       //第一偏心率
            this.e2 = 6.69438499958795E-03M;   //椭球第一偏心率平方 e2
            this.e12 = 6.73950181947292E-03M;  //椭球第二偏心率平方 e12
            this.c = 6399596.65198801M;         //极点子午圈曲率半径 c
            this.p = 206264.806252992M;      //弧度秒=180*3600/pi
            this.pi = 3.1415926535M;
        }
    }
}
