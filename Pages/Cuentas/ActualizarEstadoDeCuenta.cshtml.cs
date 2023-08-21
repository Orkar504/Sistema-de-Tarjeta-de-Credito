using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sistema_de_Tarjeta_de_Credito.Models;

namespace Sistema_de_Tarjeta_de_Credito.Pages.Cuentas
{
    public class ActualizarEstadoDeCuentaModel : PageModel
    {
        private readonly TarjetaDeCreditoContext _context;

        public ActualizarEstadoDeCuentaModel(TarjetaDeCreditoContext context)
        {
            _context = context;
        }

        [BindProperty]
        public EstadoCuentum EstadoCuenta { get; set; } = default!;
        [BindProperty]
        public DateTime fechac { get; set; } = default!;
        [BindProperty]
        public DateTime fechamp { get; set; } = default!;


        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.EstadoCuenta == null)
            {
                return NotFound();
            }

            var estadocuenta =  await _context.EstadoCuenta.FirstOrDefaultAsync(m => m.EstadoCuentaId == id);
            if (estadocuenta == null)
            {
                return NotFound();
            }
            fechac = DateTime.Parse(estadocuenta.FechaCorte.ToString());
            fechamp = DateTime.Parse(estadocuenta.FechaMaximaPago.ToString());
  
            
            EstadoCuenta = estadocuenta;
            return Page();
        }



        public async Task<IActionResult> OnPostAsync()
        {

            EstadoCuenta.FechaCorte = DateOnly.FromDateTime(fechac);
            EstadoCuenta.FechaMaximaPago = DateOnly.FromDateTime(fechamp);
            
            _context.Attach(EstadoCuenta).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EstadoCuentumExists(EstadoCuenta.EstadoCuentaId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Cuenta");
        }

        private bool EstadoCuentumExists(int id)
        {
          return (_context.EstadoCuenta?.Any(e => e.EstadoCuentaId == id)).GetValueOrDefault();
        }
    }
}
