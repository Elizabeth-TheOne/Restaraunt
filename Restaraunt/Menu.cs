using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaraunt
{
    class Menu
    {
        List<MenuItem> course = new List<MenuItem>();

        public Menu (List<MenuItem> course)
        {
            this.course = course;
        }
    }
}
