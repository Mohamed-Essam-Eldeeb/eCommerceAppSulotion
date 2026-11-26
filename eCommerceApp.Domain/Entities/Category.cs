using System.ComponentModel.DataAnnotations;

namespace eCommerceApp.Domain.Entities
{
    public class Category
    {
        [Key]
        
        public ICollection<category>? categorys {get; set;}

    }
}