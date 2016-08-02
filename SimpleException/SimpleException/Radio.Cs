using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleException
{
    class Radio
    {
        public void TornOn(bool on)
        {
            if (on)
                Console.WriteLine("Jamming");
            else
                Console.WriteLine("Quiet time");
        }
    }
}
