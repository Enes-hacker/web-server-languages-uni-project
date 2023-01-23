namespace WAREHOUSE_MANAGEMENT_SYSTEM.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Product : BaseModel
    {

        [Required]
        [MaxLength(50, ErrorMessage = "Максималната дължина на полето 'Име на продукта' е 50 символа")]
        public string Name { get; set; }

        [MaxLength(2000, ErrorMessage = "Максималната дължина на полето 'Име на продукта' е 2000 символа")]
        public string Description { get; set; }

        [Required]
        [Range(0, 999999, ErrorMessage = "Can not be less than 0...more than 999 999")]
        public decimal Cost { get; set; } //bought

        [Required]
        [Range(0, 999999, ErrorMessage = "Can not be less than 0... more than 999 999")]
        public decimal Price { get; set; } //for sale

        [Required]
        [Range(0, 9000, ErrorMessage = "Can not be less than 0... more than 9000")]
        public int Count { get; set; }

       
        public string ImageUrl { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }




    }
}
