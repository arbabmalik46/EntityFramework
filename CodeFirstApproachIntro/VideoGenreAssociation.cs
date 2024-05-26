namespace CodeFirstApproachIntro
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VideoGenreAssociation")]
    public partial class VideoGenreAssociation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int VideoGenreID { get; set; }

        public long? VideoID { get; set; }

        public int? GenreID { get; set; }

        public virtual Genre Genre { get; set; }

        public virtual Video Video { get; set; }
    }
}
