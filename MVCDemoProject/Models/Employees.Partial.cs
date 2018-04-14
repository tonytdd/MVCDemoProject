namespace MVCDemoProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(EmployeesMetaData))]
    public partial class Employees
    {
    }
    
    public partial class EmployeesMetaData
    {
        [Required]
        public int EmployeeID { get; set; }
        
        [StringLength(20, ErrorMessage="欄位長度不得大於 20 個字元")]
        [Required]
        public string LastName { get; set; }
        
        [StringLength(10, ErrorMessage="欄位長度不得大於 10 個字元")]
        [Required]
        public string FirstName { get; set; }
        
        [StringLength(30, ErrorMessage="欄位長度不得大於 30 個字元")]
        public string Title { get; set; }
        
        [StringLength(25, ErrorMessage="欄位長度不得大於 25 個字元")]
        public string TitleOfCourtesy { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public Nullable<System.DateTime> HireDate { get; set; }
        
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
        public string HomePhone { get; set; }
        
        [StringLength(4, ErrorMessage="欄位長度不得大於 4 個字元")]
        public string Extension { get; set; }
        public byte[] Photo { get; set; }
        public string Notes { get; set; }
        public Nullable<int> ReportsTo { get; set; }
        
        [StringLength(255, ErrorMessage="欄位長度不得大於 255 個字元")]
        public string PhotoPath { get; set; }
    
        public virtual ICollection<Employees> Employees1 { get; set; }
        public virtual Employees Employees2 { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
        public virtual ICollection<Territories> Territories { get; set; }
    }
}
