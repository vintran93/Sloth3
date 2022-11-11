using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sloth3
{
    class ItalianChef : Chef
    {
        public override void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes chicke parm");
        }
        public void MakePasta()
        {
            Console.Write("The Chef makes pasta");
        }
    }
}
