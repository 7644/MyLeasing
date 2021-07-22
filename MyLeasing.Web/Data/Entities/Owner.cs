using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace MyLeasing.Web.Data.Entities


{
    //Notacion para autorizar los usuarios que sean administradores 
    [Authorize(Roles ="Manager")]
    //Creacion de la tabla del propietario para manipular los datos como orm
    public class Owner
    {
        public int Id { get; set; }

        // trae este usuario para implementar todos los campos de la tabla
       public User User { get; set; }
  
        // un propietario tiene muchas propiedades
        public ICollection<Property> Properties { get; set; }


        public ICollection<Contract> Contracts { get; set; }





    }
}
