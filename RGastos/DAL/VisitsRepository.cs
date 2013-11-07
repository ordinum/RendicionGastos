using System;
using System.Collections.Generic;
using System.Linq;
using RGastos.DAL;

namespace RGastos.DAL
{
    public class VisitsRepository : IVisitsRepository, IDisposable
    {
        //Utiliza conexión de datos para BD de Visitas...
        private CVisitsDataContext context;

        public VisitsRepository(CVisitsDataContext context){
            this.context = context;
        }

        public IEnumerable<Visita> GetVisits()
        {
            return context.Visita.ToList();
        }

        
        public Visita GetVisitByID(int visitId)
        {
            //Consulta con base de datos...
            var visita = context.Visita.Where(v => v.VisitaID == visitId).FirstOrDefault();
            return (visita);
        }


        //
        // Garbage Collector
        //
       
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}