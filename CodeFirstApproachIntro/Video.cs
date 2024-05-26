namespace CodeFirstApproachIntro
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Video
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Video()
        {
            VideoGenreAssociations = new HashSet<VideoGenreAssociation>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long VideoID { get; set; }

        [StringLength(10)]
        public string VideoName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VideoGenreAssociation> VideoGenreAssociations { get; set; }
    }
}
