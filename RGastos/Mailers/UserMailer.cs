using Mvc.Mailer;

namespace RGastos.Mailers
{ 
    public class UserMailer : MailerBase, IUserMailer 	
	{
		public UserMailer()
		{
			MasterName="_Layout";
		}
	

        public virtual MvcMailMessage EnvioRendicion(string mailaprobador, int rendicionid, int customervisitid, string descripcion, string gasto, string usuario)
        {
            ViewBag.RendicionID = rendicionid;
            ViewBag.CustomerVisit = customervisitid;
            ViewBag.Descripcion = descripcion;
            ViewBag.Gasto = gasto;
            ViewBag.Usuario = usuario;

            return Populate(x =>
            {
                x.Subject = "Se ha ingresado una Rendici�n de Gastos para su aprobaci�n.";
                x.ViewName = "EnvioRendicion";
                x.To.Add(mailaprobador);
            });
        }

        public virtual MvcMailMessage AprobacionRendicion(string nombreaprobador, int rendicionid, int customervisitid, string descripcion, string gasto, string mailusuario)
        {
            ViewBag.RendicionID = rendicionid;
            ViewBag.CustomerVisit = customervisitid;
            ViewBag.Descripcion = descripcion;
            ViewBag.Gasto = gasto;
            ViewBag.Usuario = mailusuario;
            ViewBag.Aprobador = nombreaprobador;

            return Populate(x =>
            {
                x.Subject = "Estado Aprobaci�n Rendici�n de Gasto";
                x.ViewName = "AprobacionRendicion";
                x.To.Add(mailusuario);
            });
        }
 	}
}