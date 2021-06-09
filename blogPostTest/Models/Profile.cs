using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace blogPostTest.Models
{
    public partial class Profile
    {
        public Profile()
        {
            PermissionByProfiles = new HashSet<PermissionByProfile>();
            Users = new HashSet<User>();
        }

        [Key]
        public int ProfId { get; set; }
        public string ProfName { get; set; }

        public virtual ICollection<PermissionByProfile> PermissionByProfiles { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
