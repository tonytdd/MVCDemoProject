namespace MVCDemoProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(RegionMetaData))]
    public partial class Region
    {
    }
    
    public partial class RegionMetaData
    {
        [Required]
        public int RegionID { get; set; }
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        [Required]
        public string RegionDescription { get; set; }
    
        public virtual ICollection<Territories> Territories { get; set; }
    }
}
