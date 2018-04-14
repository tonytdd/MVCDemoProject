namespace MVCDemoProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(TerritoriesMetaData))]
    public partial class Territories
    {
    }
    
    public partial class TerritoriesMetaData
    {
        
        [StringLength(20, ErrorMessage="欄位長度不得大於 20 個字元")]
        [Required]
        public string TerritoryID { get; set; }
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        [Required]
        public string TerritoryDescription { get; set; }
        [Required]
        public int RegionID { get; set; }
    
        public virtual Region Region { get; set; }
        public virtual ICollection<Employees> Employees { get; set; }
    }
}
