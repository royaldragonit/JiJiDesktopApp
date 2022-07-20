using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ji.Model.Entities
{
    public class Supporter
    {

        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string Cccd { get; set; }
        public string Image { get; set; }
        public string FullName { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Roles { get; set; }
        public bool? Active { get; set; }
        public DateTime CreateOn { get; set; }
        public string ConnectionId { get; set; }

    }
}
