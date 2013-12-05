using System.Collections.Generic;
using RGastos.Models;

namespace RGastos.ViewModels
{
    public class RendicionIndexData
    {        
        public IEnumerable<Rendicion> RendicionesPendientes { get; set; }
        public IEnumerable<Rendicion> RendicionesAprobadas { get; set; }
        public IEnumerable<Rendicion> RendicionesRechazadas { get; set; }
    }
}