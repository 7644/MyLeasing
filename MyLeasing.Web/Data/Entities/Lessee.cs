using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace MyLeasing.Web.Data.Entities
{
    public class Lessee
    {
        public int Id { get; set; }



        public User User { get; set; }
        //Propiedad de solo lectura que concatena el nombre y el apellido
        //una propiedad de lectura solo tiene el metodo get

        public ICollection<Contract> contracts { get; set; }


    }
}
