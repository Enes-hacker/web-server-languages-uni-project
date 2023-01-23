namespace WAREHOUSE_MANAGEMENT_SYSTEM.Data.Models
{
    using System;
    public class BaseModel
    {
        public BaseModel()
            {
               this.Id = Guid.NewGuid(); 
            }

        public Guid Id { get; set; } //Guid is better option, because it prevents from hack attacks
    }
}
