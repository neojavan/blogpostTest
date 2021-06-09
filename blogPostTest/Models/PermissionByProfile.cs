using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace blogPostTest.Models
{
    public partial class PermissionByProfile
    {
        [Key]
        public int PbpId { get; set; }
        public int PbpPermId { get; set; }
        public int PbpProfId { get; set; }

        public virtual Permission PbpPerm { get; set; }
        public virtual Profile PbpProf { get; set; }
    }
}
