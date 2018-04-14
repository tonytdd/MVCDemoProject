namespace MVCDemoProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(CategoriesMetaData))]
    public partial class Categories
    {
    }
    
    public partial class CategoriesMetaData
    {
        [Required]
        public int CategoryID { get; set; }
        
        [StringLength(15, ErrorMessage="欄位長度不得大於 15 個字元")]
        [Required]
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }
    
        public virtual ICollection<Products> Products { get; set; }
    }
}
