using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sistema_de_Tarjeta_de_Credito.Models;

namespace Sistema_de_Tarjeta_de_Credito.Pages.Cuentas
{
    
    public class CuentaModel : PageModel
    {
        public readonly TarjetaDeCreditoContext _context;
        public CuentaModel(TarjetaDeCreditoContext context)
        {
            _context = context;
        }

        [BindProperty]
        public IEnumerable<Cuentum> cuentas { get; set; } = default!;
        [BindProperty]
        public Cliente client { get; set; } = default!;
        public void OnGet()
        {

            cuentas = _context.Cuenta;
        }
    }
}
