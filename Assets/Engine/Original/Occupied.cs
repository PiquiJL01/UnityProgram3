using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAlgoritmos
{
    public class Occupied : Status
    {
        public bool IsFree()
        {
            return false;
        }

        public bool Cleanable()
        {
            return true;
        }
    }
}
