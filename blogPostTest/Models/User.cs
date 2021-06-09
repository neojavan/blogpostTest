using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace blogPostTest.Models
{
    public partial class User
    {
        public User()
        {
            Posts = new HashSet<Post>();
        }

        [Key]
        public int UsrId { get; set; }

        [Required]
        [Display(Name = "Login")]
        [StringLength(50, ErrorMessage = "{0} must be at least {2} characters long.", MinimumLength = 2)]
        public string UsrLogin { get; set; }
        
        [Required]
        [DataType(DataType.Password)]
        [StringLength(250, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 8)]
        [Display(Name = "Password")]
        [RegularExpression("^((?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])|(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[^a-zA-Z0-9])|(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])|(?=.*?[a-z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])).{8,}$", ErrorMessage = "Passwords must be at least 8 characters and contain at 3 of 4 of the following: upper case (A-Z), lower case (a-z), number (0-9) and special character (e.g. !@#$%^&*)")]
        public string UsrPassword { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [StringLength(100, ErrorMessage = "{0} must be at least {2} characters long.", MinimumLength = 2)]
        public string UsrFirstname { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(100, ErrorMessage = "{0} must be at least {2} characters long.", MinimumLength = 2)]
        public string UsrLastname { get; set; }

        [Required]
        [Display(Name = "Mobile Number")]
        [StringLength(50, ErrorMessage = "{0} must be at least {2} characters long.", MinimumLength = 2)]
        public string UsrMobile { get; set; }


        public DateTime UsrRegisterDate { get; set; }

        [Required]
        [Display(Name = "Profile")]
        public int UsrProfId { get; set; }

        public virtual Profile UsrProf { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}
