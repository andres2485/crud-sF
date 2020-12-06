using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace demo_crud.Models
{
    public class Usuario
    {

        public int Id { get; set; }
        
        [Required]
        [StringLength(25, MinimumLength =3)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(25, MinimumLength = 3)]
        public string Apellido{ get; set; }


        [Required]
        [Range(0,99)]
        public int Edad { get; set; }
        [Required]
        [StringLength(25, MinimumLength = 10)]
        public string Direccion { get; set; }
        [Required]
        
        public int Telefono { get; set; }

    }
}