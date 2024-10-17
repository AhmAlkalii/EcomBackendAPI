using System.ComponentModel.DataAnnotations;

namespace Ecommerce_Api.Models.Dto
{
    /* We created two dto's for create and updating becuase when creating we dont need our function refrencing the menuitem model the 
     * id field is present there and we dont need that when creating as it is assigned auto and same goes for the update
     */
    public class MenuItemCreateDTO
    {
    
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
