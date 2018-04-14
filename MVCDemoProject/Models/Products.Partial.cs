namespace MVCDemoProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(ProductsMetaData))]
    public partial class Products
    {
    }
    
    public partial class ProductsMetaData
    {
        [Required]
        public int ProductID { get; set; }
        
        [StringLength(40, ErrorMessage="欄位長度不得大於 40 個字元")]
        [Required]
        public string ProductName { get; set; }
        public Nullable<int> SupplierID { get; set; }
        public Nullable<int> CategoryID { get; set; }
        
        [StringLength(20, ErrorMessage="欄位長度不得大於 20 個字元")]
        public string QuantityPerUnit { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public Nullable<short> UnitsInStock { get; set; }
        public Nullable<short> UnitsOnOrder { get; set; }
        public Nullable<short> ReorderLevel { get; set; }
        [Required]
        public bool Discontinued { get; set; }
    
        public virtual Categories Categories { get; set; }
        public virtual ICollection<Order_Details> Order_Details { get; set; }
        public virtual Suppliers Suppliers { get; set; }
    }
}
