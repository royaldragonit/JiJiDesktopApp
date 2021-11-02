using System;
namespace Ji.Model
{
    public class Users
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public bool Active { get; set; }
        public string Image { get; set; }
        public string Roles { get; set; }
        public string token { get; set; }
        public string FacID { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime CreateOn { get; set; }
    }
}
