namespace Gre.Ap.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Course")]
    public partial class Course
    {
        public long Id { get; set; }

        [StringLength(200)]
        public string NameCourse { get; set; }

        public long? IdLanguage { get; set; }
    }
}
