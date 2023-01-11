using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNRT.Shared.Entites
{
    public class Club
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        // one to one 
        /*public int RiderId { get; set; }
        public Rider Rider { get; set; }*/

        public List<Rider>?  Riders { get; set; }
    }
}
