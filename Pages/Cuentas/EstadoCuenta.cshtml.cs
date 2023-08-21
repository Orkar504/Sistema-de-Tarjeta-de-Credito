using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sistema_de_Tarjeta_de_Credito.Models;
using System.Security.Policy;

namespace Sistema_de_Tarjeta_de_Credito.Pages.Cuentas
{
    public class EstadoCuentaModel : PageModel
    {
        public readonly TarjetaDeCreditoContext _context;
        public EstadoCuentaModel(TarjetaDeCreditoContext context)
        {
            _context = context;
        }
        [BindProperty]
        public EstadoCuentum estadoCuenta { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var datlab = await _context.EstadoCuenta.FirstOrDefaultAsync(m => m.CuentaId == id);
            if(datlab == null)
            {
                return NotFound();
            }
            else
            {
                estadoCuenta = datlab;
            }
            return Page();
        } 
    }
}
