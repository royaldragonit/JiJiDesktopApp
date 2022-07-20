using System;
using System.Collections.Generic;

namespace Ji.Model.Entities
{
    public partial class Bhxh
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Roles { get; set; }
        public bool? Active { get; set; }
        public DateTime CreateOn { get; set; }
        public string ConnectionId { get; set; }
        public string MacAddress { get; set; }
    }
}