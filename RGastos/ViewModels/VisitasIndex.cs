using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RGastos.Models;

namespace RGastos.ViewModels
{
    public class VisitasIndex
    {
        public IEnumerable<Rendicion> Rendicion { get; set; }
        public string DescripcionVisita { get; set; }
    }
}