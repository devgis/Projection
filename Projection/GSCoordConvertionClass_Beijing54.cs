using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projection
{
    /// <summary>
    /// 北京54坐标
    /// vp:hsg
    /// create date:2015-12
    /// </summary>
    public class GSCoordConvertionClass_Beijing54 : ProjectionConversion2, IProjectionConversion2
    {
        public GSCoordConvertionClass_Beijing54()
        {
            //长半轴a = 6378245m；
            //短半轴 = 6356863.0188m；
            //扁率α = 1 / 298.3；
            //第一偏心率平方 = 0.006693421622。

            this.a = 6378245m;           //北京54椭球长半轴
            this.b = 6356863.0188m;        //北京54椭球短半轴
            this.f = 1 / 298.3M;     //椭球扁率f
            this.e = 0.08181333401102781118710054879576M;       //第一偏心率
            this.e2 = 0.006693421622M;   //椭球第一偏心率平方 e2
            this.e12 = 6.73950181947292E-03M;  //椭球第二偏心率平方 e12
            this.c = 6399596.65198801M;         //极点子午圈曲率半径 c
            this.p = 206264.806252992M;      //弧度秒=180*3600/pi
            this.pi = 3.1415926535M;
        }
    }
}
