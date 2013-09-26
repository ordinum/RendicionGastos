using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace RGastos.Models
{
    public class Ciudad
    {
        //ID
        public int CiudadID { get; set; }

        [Required]        
        public string Nombre { get; set; }


        //---------------------------------------------------
        // RELACIONES
        //

        //A uno...
        public int PaisID { get; set; }

        public virtual Pais Pais { get; set; }
       
    }
}