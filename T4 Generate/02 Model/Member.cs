using System;
using System.Collections.Generic;
using System.Text;

namespace NEO.Core
{
    public class Member
    {
        public int Id { get; set; }
        public string Uid { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public int ProfileId { get; set; }
        public int RoleId { get; set; }
        public int OrganizationId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public int CreatedById { get; set; }
        public DateTime ModifyDate { get; set; }
        public string ModifyBy { get; set; }
        public int ModifyById { get; set; }
    }
}
