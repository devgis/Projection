
using System;
using System.Collections.Generic;
using System.Text;

namespace Projection.Gauss
{

    /// <summary>
    /// Krasovsky�ο����� ����(����54����ϵ���ô˲ο�����)
    /// </summary>
    public class Beijing54 : GaussPrjBase
    {

        public Beijing54()
        {
            _a = 6378245.0;
            _f = 1.0 / 298.3;
        }
    }
}
