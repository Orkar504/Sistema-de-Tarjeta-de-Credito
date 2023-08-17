using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Sistema_de_Tarjeta_de_Credito.Pages
{
    //En base a la política creada permite el acceso a solo las personas que tengan autorizacion con la politica DebePertenecerAEmpleado
    [Authorize(Policy = "DebePertenecerAEmpleado")]
    public class Solicitud_de_TarjetaModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
