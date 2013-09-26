using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RGastos.Models;
using RGastos.DAL;

namespace RGastos.ViewModels
{
    public class ListadoPrueba
    {
        public IEnumerable<Visita> Visita { get; set; }
    }
}