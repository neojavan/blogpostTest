using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


#nullable disable

namespace blogPostTest.Models
{
    public partial class Permission
    {
        public Permission()
        {
            PermissionByProfiles = new HashSet<PermissionByProfile>();
        }

        [Key]
        public int PermsId { get; set; }
        public string PermsAction { get; set; }

        public virtual ICollection<PermissionByProfile> PermissionByProfiles { get; set; }
    }
}
