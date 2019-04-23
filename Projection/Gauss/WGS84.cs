
using System;
using System.Collections.Generic;
using System.Text;

namespace Projection.Gauss
{
    /// <summary>
    /// WGS84�ο����� ����(ȫ��GPS��������ô˲ο�����)
    /// </summary>
    public class WGS84 : GaussPrjBase
    {
        public WGS84()
        {
            _a = 6378137.0;
            _f = 1.0 / 298.257223563;

        }
    }
}
