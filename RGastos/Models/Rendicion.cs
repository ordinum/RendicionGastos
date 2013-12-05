using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RGastos.DAL;

namespace RGastos.Models
{
    public class Rendicion
    {

        //ID
        public int RendicionID { get; set; }
        
        [DataType(DataType.Date)]
        [DisplayName("Fecha Ingreso")]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Debe ingresar una fecha")]
        public DateTime Fecha { get; set; }
        
        [Required]
        [DataType(DataType.MultilineText)]
        public string Descripcion { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public double Gasto { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Observacion { get; set; }


        [Required]
        [DisplayName("Correlativo Visita")]
        public int VisitaID { get; set; } //Se accede a través de Clase de Contexto Especial

        //[Required]
        //[DisplayName("Approver Name")]
        public int AprobadorID { get; set; }
        public virtual Aprobador Aprobador { get; set; }

        public int RendicionStatusID { get; set; }
        public virtual RendicionStatus RendicionStatus { get; set; }

        //---------------------------------------------------
        // RELACIONES
        //
        
        //A uno...
        public int UserId { get; set; }                
        public virtual UserProfile UserProfile { get; set; }
        

    }
}