namespace MVCDemoProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(CustomerDemographicsMetaData))]
    public partial class CustomerDemographics
    {
    }
    
    public partial class CustomerDemographicsMetaData
    {
        
        [StringLength(10, ErrorMessage="欄位長度不得大於 10 個字元")]
        [Required]
        public string CustomerTypeID { get; set; }
        public string CustomerDesc { get; set; }
    
        public virtual ICollection<Customers> Customers { get; set; }
    }
}
