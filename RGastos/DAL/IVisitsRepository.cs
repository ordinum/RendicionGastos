using System;
using System.Collections.Generic;

namespace RGastos.DAL
{
    public interface IVisitsRepository : IDisposable
    {        
        IEnumerable<Visita> GetVisits();
        Visita GetVisitByID(int visitId);                
    }
}