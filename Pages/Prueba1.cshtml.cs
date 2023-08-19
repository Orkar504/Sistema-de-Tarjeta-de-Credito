using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace Sistema_de_Tarjeta_de_Credito.Pages
{
    [Authorize(Policy = "Solicitudes")]
    [Authorize]
    public class Prueba1Model : PageModel
    {
        public void OnGet()
        {
        }
    }
}
