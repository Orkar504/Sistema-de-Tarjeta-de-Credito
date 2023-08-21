using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
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

        /**********************************************************/

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            var cuenta = await _context.Cuenta.FirstOrDefaultAsync(c => c.CuentaId == id);
            var estadoCuenta = await _context.EstadoCuenta.FirstOrDefaultAsync(c => c.CuentaId == cuenta.CuentaId);
            _context.EstadoCuenta.Remove(estadoCuenta);
                _context.Cuenta.Remove(cuenta);
                await _context.SaveChangesAsync();
            return RedirectToPage("./Cuenta");
        }
        /**********************************************************/
    }
}
