using System.ComponentModel.DataAnnotations;

namespace Ecommerce_Api.Models.Dto
{
    public class MenuItemUpdateDTO
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string SpecialTag { get; set; }
        public string Category { get; set; }
        [Range(1, int.MaxValue)]
        public double Price { get; set; }
        
        //when we are creating or updating a menuitem we will get the form file and not the image field as it was previously
        public IFormFile File { get; set; }
    }
}
