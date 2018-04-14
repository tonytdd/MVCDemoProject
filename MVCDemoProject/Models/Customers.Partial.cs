namespace MVCDemoProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(CustomersMetaData))]
    public partial class Customers
    {
    }
    
    public partial class CustomersMetaData
    {
        
        [StringLength(5, ErrorMessage="欄位長度不得大於 5 個字元")]
        [Required]
        public string CustomerID { get; set; }
        
        [StringLength(40, ErrorMessage="欄位長度不得大於 40 個字元")]
        [Required]
        public string CompanyName { get; set; }
        
        [StringLength(30, ErrorMessage="欄位長度不得大於 30 個字元")]
        public string ContactName { get; set; }
        
        [StringLength(30, ErrorMessage="欄位長度不得大於 30 個字元")]
        public string ContactTitle { get; set; }
        
        [StringLength(60, ErrorMessage="欄位長度不得大於 60 個字元")]
        public string Address { get; set; }
        
        [StringLength(15, ErrorMessage="欄位長度不得大於 15 個字元")]
        public string City { get; set; }
        
        [StringLength(15, ErrorMessage="欄位長度不得大於 15 個字元")]
        public string Region { get; set; }
        
        [StringLength(10, ErrorMessage="欄位長度不得大於 10 個字元")]
        public string PostalCode { get; set; }
        
        [StringLength(15, ErrorMessage="欄位長度不得大於 15 個字元")]
        public string Country { get; set; }
        
        [StringLength(24, ErrorMessage="欄位長度不得大於 24 個字元")]
        public string Phone { get; set; }
        
        [StringLength(24, ErrorMessage="欄位長度不得大於 24 個字元")]
        public string Fax { get; set; }
    
        public virtual ICollection<Orders> Orders { get; set; }
        public virtual ICollection<CustomerDemographics> CustomerDemographics { get; set; }
    }
}
