using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Sistema_de_Tarjeta_de_Credito.Pages
{
    public class PagoCreditoModel : PageModel
    {
        
        public readonly int[] numeros = {1,2,3,4,5,6,7,8};   
        public void OnGet()
        {
        }
    }
}
