using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OICPen
{
    interface MyForm : IDisposable
    {
        Models.StaffT Staff { set; }
    }
}
