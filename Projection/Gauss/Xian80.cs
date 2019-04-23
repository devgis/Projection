
using System;
using System.Collections.Generic;
using System.Text;

namespace Projection.Gauss
{
    /// <summary>
    /// IUGG1975�ο����� ����(����54����ϵ���ô˲ο�����)
    /// </summary>
    public class Xian80 : GaussPrjBase
    {
        public Xian80()
        {
            _a = 6378140.0;
            _f = 1.0 / 298.257;
        }
    }
}
