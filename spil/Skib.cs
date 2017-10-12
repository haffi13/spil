using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spil
{
    class Skib
    {
       public int length;
       public int amount;
       public string name;
       public int startX;
       public int startY;
       public int direction;

       public Dictionary<int, int> shipPosition = new Dictionary<int, int>();
        
    }
}
