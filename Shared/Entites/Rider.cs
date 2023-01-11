using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNRT.Shared.Entites
{
    public class Rider
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int ContactNumber { get; set; }
        public string Blood { get; set; }
        public int EnegencyContactNo { get; set; }

        // one to one
        /*public Club Club { get; set; }*/

        public int ClubId { get; set; }
        public Club? Club { get; set; }

    }
}
