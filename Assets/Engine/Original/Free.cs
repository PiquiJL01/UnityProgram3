using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAlgoritmos
{
    public class Free : Status
    {
        public bool IsFree()
        {
            return true;
        }

        public bool Cleanable()
        {
            return true;
        }
    }
}
