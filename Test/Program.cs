using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal x = 0;
            decimal y = 0;
            decimal B = 0;
            decimal L = 0;

            GSCoordConvertionClass_2000 cc = new GSCoordConvertionClass_2000();
            cc.IsBigNumber = true;
            cc.Strip = EnumStrip.Strip3;
            cc.L0 = 105;
            //
            //---------------------------------
            //反算 OK
            x = 4016159.7706M;
            y = 35358852.807M;
            cc.GetBLFromXY(x, y, ref B, ref L);
            //
            B = Math.Round(B, 8);
            L = Math.Round(L, 8);
            System.Console.WriteLine("X, Y = (" + x + ", " + y + "=>B,L=(" + B + "," + L + ")");
            //
            //正算
            //B = 36.155619734M;
            //L = 105.254854607M;
            cc.GetXYFromBL(B, L, ref x, ref y);
            System.Console.WriteLine("B,L=(" + B + "," + L + ")=>X,Y=(" + x + "," + y + "");
            //
            //System.Console.Read();
            System.Console.Clear();
            System.Console.WriteLine("--------------------------------------");
            B = 30.72047809M;
            L = 120.6576412M;
            cc.GetXYFromBL(B, L, ref x, ref y);
            System.Console.WriteLine("B,L=(" + B + "," + L + ")=>X,Y=(" + x + "," + y + "");
            //
            System.Console.Read();

        }
    }
}
