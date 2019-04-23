using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projection
{
    /// <summary>
    /// 墨卡托坐标转换（经纬度与米之间互转）
    /// </summary>
    public class MercatorConverter
    {
        /// <summary>
        /// 经纬度转Web墨卡托（单位：米）
        /// </summary>
        /// <param name="longitude">经度</param>
        /// <param name="latitude">纬度</param>
        /// <returns></returns>
        public static void Degree2WebMercatorMeter(double longitude, double latitude, out double X, out double Y)
        {
            var xValue = longitude * 20037508.34 / 180;
            var y = Math.Log(Math.Tan((90 + latitude) * Math.PI / 360)) / (Math.PI / 180);
            var yValue = y * 20037508.34 / 180;
            X = xValue;
            Y = yValue;
        }

        /// <summary>
        /// 经纬度转World墨卡托（单位：米）
        /// </summary>
        /// <param name="longitude">经度</param>
        /// <param name="latitude">纬度</param>
        /// <returns></returns>
        public static void Degree2WorldMercatorMeter(double longitude, double latitude, out double X, out double Y)
        {
            const int radius = 6378137;
            const double minorRadius = 6356752.314245179;

            const double d = Math.PI / 180;
            const double r = radius;
            var y = latitude * d;
            const double tmp = minorRadius / r;
            double e = Math.Sqrt(1 - tmp * tmp),
                con = e * Math.Sin(y);

            var ts = Math.Tan(Math.PI / 4 - y / 2) / Math.Pow((1 - con) / (1 + con), e / 2);
            y = -r * Math.Log(Math.Max(ts, 1E-10));

            X = longitude * d * r;
            Y = y;
        }

        /// <summary>
        /// Web墨卡托转经纬度
        /// </summary>
        /// <param name="x">X坐标值（单位：米）</param>
        /// <param name="y">Y坐标值（单位：米）</param>
        /// <returns></returns>
        public static void WebMercatorMeter2Degree(double x, double y, out double lon, out double lat)
        {
            var xValue = x / 20037508.34 * (double)180;
            var yValue = y / 20037508.34 * (double)180;
            yValue = (double)180 / Math.PI * (2 * Math.Atan(Math.Exp(yValue * Math.PI / (double)180)) - Math.PI / (double)2);
            lon = xValue;
            lat = yValue;
        }
    }
}
