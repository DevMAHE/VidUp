//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VidUp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class VideoTag
    {
        public long VideoTagId { get; set; }
        public long VideoId { get; set; }
        public long TagId { get; set; }
    
        public virtual Tag Tag { get; set; }
        public virtual Video Video { get; set; }
    }
}
