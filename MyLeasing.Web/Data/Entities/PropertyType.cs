using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyLeasing.Web.Data.Entities
{
    public class PropertyType
    {

        public int Id {get;set;}


        [Display(Name="Property Type*")]
        [MaxLength(50, ErrorMessage = "The {0} field not have more than {1} characteres.")]
        [Required(ErrorMessage ="The fiels {0} is mandatory.")]
        
        public string Name { get; set; }

        //Para crear relaciones de uno a muchos  es recomendable colocar las relaciones en los dos modelos
        public ICollection<Property> Properties{ get; set; }
    }
}
