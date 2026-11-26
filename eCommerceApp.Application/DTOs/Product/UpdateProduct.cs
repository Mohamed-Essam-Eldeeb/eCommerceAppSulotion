using System.ComponentModel.DataAnnotations;

namespace eCommerceApp.Application.DTOs.Product
{
    public class UpdateProduct : categoryBase
    {
        [Required]
        public Guid Id { get; set; }
        
    }
}
