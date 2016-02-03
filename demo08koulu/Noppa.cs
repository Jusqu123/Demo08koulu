using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo08koulu
{
    class Noppa
    {
        //field variable
    private    Random rand = new Random();
        public int Heita()
        {
       // 0-5 +1 -> 1-6
            return rand.Next(6) + 1;
        }

        



    }

}