using Mvc.Mailer;

namespace RGastos.Mailers
{ 
    public interface IUserMailer
    {        
        MvcMailMessage EnvioRendicion(string mailaprobador, int rendicionid, int customervisitid, string descripcion, string gasto, string usuario);
        MvcMailMessage AprobacionRendicion(string nombreaprobador, int rendicionid, int customervisitid, string descripcion, string gasto, string mailusuario);
	}
}