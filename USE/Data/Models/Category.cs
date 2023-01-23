namespace WAREHOUSE_MANAGEMENT_SYSTEM.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Category : BaseModel
    {

        public Category() //for less memory consumption
        {
            this.Products = new HashSet<Product>(); 
        }

        [Required]
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
