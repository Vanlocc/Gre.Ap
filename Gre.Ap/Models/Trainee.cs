namespace Gre.Ap.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Trainee")]
    public partial class Trainee
    {
        public long Id { get; set; }

        [Required]
        [StringLength(200)]
        [Display(Name ="Full Name")]
        public string FullName { get; set; }

        [Column(TypeName = "date")]
        [Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }
        [Display(Name = "Gender")]
        public long IdGender { get; set; }

        [Required]
        [StringLength(200)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(200)]
        [Display(Name = "Phone")]
        public string Phone { get; set; }

        [Required]
        [StringLength(200)]
        [Display(Name = "Address")]
        public string Address { get; set; }
        [Display(Name = "Course")]
        public long IdCourse { get; set; }
        [Display(Name = "Programming Language")]
        public long IdLanguage { get; set; }
    }
}
