//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExerciseDBFirst
{
    using System;
    using System.Collections.Generic;
    
    public partial class VideoGenreAssociation
    {
        public int VideoGenreID { get; set; }
        public Nullable<long> VideoID { get; set; }
        public Nullable<int> GenreID { get; set; }
    
        public virtual Genre Genre { get; set; }
        public virtual Video Video { get; set; }
    }
}