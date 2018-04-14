namespace MVCDemoProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(Order_DetailsMetaData))]
    public partial class Order_Details
    {
    }
    
    public partial class Order_DetailsMetaData
    {
        [Required]
        public int OrderID { get; set; }
        [Required]
        public int ProductID { get; set; }
        [Required]
        public decimal UnitPrice { get; set; }
        [Required]
        public short Quantity { get; set; }
        [Required]
        public float Discount { get; set; }
    
        public virtual Orders Orders { get; set; }
        public virtual Products Products { get; set; }
    }
}
