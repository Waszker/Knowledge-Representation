using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR.Main.Builders
{
    interface IBuilder<T>
    {
        T GetResult();
    }
}
