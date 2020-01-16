using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAlgoritmos
{
    public class Triangle : Box<TriangleOrientation>
    {
        public new bool IsFree(TriangleOrientation orientation)
        {
            if (IsFree())
            {
                if (Neighborhood[orientation] == null)
                {
                    return true;
                }
                else
                {
                    return Neighborhood[orientation].InverseIsFree(orientation);
                }
            }
            else
            {
                return false;
            }
        }

        public new bool InverseIsFree(TriangleOrientation orientation)
        {
            if (IsFree())
            {

            }
            else
            {
                return false;
            }

            return true;
        }
    }
}
