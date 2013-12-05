using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RGastos.Models
{
    public class Aprobador
    {
        public int AprobadorID { get; set; }

        [Required]
        [DisplayName("Approver Name")]
        public string ApproverName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        //Relaciones        
        public virtual ICollection<Rendicion> Rendicion {get;set;}

    }
}