using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace RGastos.Models
{
    public class RendicionStatus
    {
        public int RendicionStatusID { get; set; }
        
        [Required]
        public string Descripcion { get; set; }

        public virtual ICollection<Rendicion> Rendicion { get; set; }
    }
}