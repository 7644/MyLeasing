using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyLeasing.Web.Data.Entities
{
    public class Property
    {

        public int Id { get; set; }

        [Display(Name = "Neighborhood")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Neighborhood { get; set; }

        [Display(Name = "Address")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Address { get; set; }

        //precio
        [Display(Name = "Price")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Price { get; set; }

        //metros cuadrados
        [Display(Name = "Square meters")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public int SquareMeters { get; set; }

        //habitaciones
       
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public int Rooms { get; set; }

        //estrato

        [Display(Name = "Stratum")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public int Stratum { get; set; }
        
        //parqueadero

        [Display(Name = "Has Parking Lot?")]
        public bool HasParkingLot { get; set; }

        //si esta disponible

        [Display(Name = "Is Available?")]
        public bool IsAvailable { get; set; }

        //comentarios
        public string Remarks { get; set; }
        //Para crear relaciones de uno a muchos se debe crear en ambas tablas
        public PropertyType PropertyType { get; set; }

        public Owner Owner { get; set; }

        // una propiedad tiene muchas imagenes 
        public ICollection<PropertyImage> propertyImages { get; set; }

        //una propiedad tien muchos contratos

        public ICollection<Contract> contracts { get; set; }


    }
}
