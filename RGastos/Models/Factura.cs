using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RGastos.Models
{
    public class Factura
    {

        //ID
        public int FacturaID { get; set; }

        [Required]
        public string NumeroFactura { get; set; }

        [Required]
        public string RutEmisor { get; set; }

        [Required]
        public string NombreEmisor { get; set; }
        
        [DataType(DataType.Date)]
        [DisplayName("Fecha Emisión")]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Debe ingresar una fecha")]
        public DateTime FechaEmision { get; set; }

        [Required]
        public double ValorNeto { get; set; }

        //---------------------------------------------------
        // RELACIONES
        //

        //A uno...
        public int RendicionID { get; set; }

        public virtual Rendicion Rendicion { get; set; }


    }
}