namespace MVCDemoProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(ShippersMetaData))]
    public partial class Shippers
    {
    }
    
    public partial class ShippersMetaData
    {
        [Required]
        public int ShipperID { get; set; }
        
        [StringLength(40, ErrorMessage="欄位長度不得大於 40 個字元")]
        [Required]
        public string CompanyName { get; set; }
        
        [StringLength(24, ErrorMessage="欄位長度不得大於 24 個字元")]
        public string Phone { get; set; }
    
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
