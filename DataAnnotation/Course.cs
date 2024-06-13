namespace DataAnnotation
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Courses")]
    public partial class Course
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Course()
        {
            Tags = new HashSet<Tag>();
        }

        [Required]
        public int Id { get; set; }

        public string Title { get; set; }
        
        [MaxLength(255)]
        [Required]
        public string Description { get; set; }

        public int Level { get; set; }

        public float FullPrice { get; set; }

        [ForeignKey("Author")]
        public int? Author_Id { get; set; }

        public int? Category_ID { get; set; }

        public DateTime? DatePublished { get; set; }

        public virtual Author Author { get; set; }

        public virtual Category Category { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tag> Tags { get; set; }
    }
}
