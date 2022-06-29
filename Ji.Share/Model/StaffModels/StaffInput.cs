using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ji.Model.StaffModels
{
    public class StaffInput
    {
        public int StaffId { get; set; }
        public string FullName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public bool? Active { get; set; }
        public string Image { get; set; }
        public string Roles { get; set; }
        public string Token { get; set; }
        public int FacId { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime CreateOn { get; set; }
        public List<int> ListPermissionId { get; set; }
    }
}
