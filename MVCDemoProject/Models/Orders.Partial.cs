namespace MVCDemoProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(OrdersMetaData))]
    public partial class Orders
    {
    }
    
    public partial class OrdersMetaData
    {
        [Required]
        public int OrderID { get; set; }
        
        [StringLength(5, ErrorMessage="欄位長度不得大於 5 個字元")]
        public string CustomerID { get; set; }
        public Nullable<int> EmployeeID { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public Nullable<System.DateTime> RequiredDate { get; set; }
        public Nullable<System.DateTime> ShippedDate { get; set; }
        public Nullable<int> ShipVia { get; set; }
        public Nullable<decimal> Freight { get; set; }
        
        [StringLength(40, ErrorMessage="欄位長度不得大於 40 個字元")]
        public string ShipName { get; set; }
        
        [StringLength(60, ErrorMessage="欄位長度不得大於 60 個字元")]
        public string ShipAddress { get; set; }
        
        [StringLength(15, ErrorMessage="欄位長度不得大於 15 個字元")]
        public string ShipCity { get; set; }
        
        [StringLength(15, ErrorMessage="欄位長度不得大於 15 個字元")]
        public string ShipRegion { get; set; }
        
        [StringLength(10, ErrorMessage="欄位長度不得大於 10 個字元")]
        public string ShipPostalCode { get; set; }
        
        [StringLength(15, ErrorMessage="欄位長度不得大於 15 個字元")]
        public string ShipCountry { get; set; }
    
        public virtual Customers Customers { get; set; }
        public virtual Employees Employees { get; set; }
        public virtual ICollection<Order_Details> Order_Details { get; set; }
        public virtual Shippers Shippers { get; set; }
    }
}
