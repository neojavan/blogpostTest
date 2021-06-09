using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace blogPostTest.Models
{
    public partial class Post
    {
        [Key]
        public int PostId { get; set; }
        [Required]
        [Display(Name = "User")]
        public int PostUsrId { get; set; }

        [Required]
        [Display(Name = "Title")]
        [StringLength(500, ErrorMessage = "{0} must be at least {2} characters long.", MinimumLength = 2)]
        public string PostTitle { get; set; }

        [Required]
        [Display(Name = "Post Content")]
        [StringLength(10000, ErrorMessage = "{0} must be at least {2} characters long.", MinimumLength = 2)]
        [DataType(DataType.MultilineText)]
        public string PostContent { get; set; }

        [Required]
        [Display(Name = "Summary")]
        [StringLength(500, ErrorMessage = "{0} must be at least {2} characters long.", MinimumLength = 2)]
        public string PostSummary { get; set; }

        [Display(Name = "Creation Date")]
        public DateTime PostCreated { get; set; }

        [Display(Name = "Publish Date")]
        public DateTime? PostPublished { get; set; }

        [Display(Name = "Update Date")]
        public DateTime? PostUpdated { get; set; }

        [Display(Name = "Status")]
        public string PostStatus { get; set; }

        public virtual User PostUsr { get; set; }
    }
}
