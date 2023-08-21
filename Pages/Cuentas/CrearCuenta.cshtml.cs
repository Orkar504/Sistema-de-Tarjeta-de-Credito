using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sistema_de_Tarjeta_de_Credito.Models;

namespace Sistema_de_Tarjeta_de_Credito.Pages.Cuentas
{
    public class CrearCuentaModel : PageModel
    {
        private readonly TarjetaDeCreditoContext _context;

        public CrearCuentaModel(TarjetaDeCreditoContext context)
        {
            _context = context;
        }

        public void OnGet()
        {

        }

        [BindProperty]
        public Cuentum cuenta { get; set; } = default!;
        
        public async Task<IActionResult> OnPostAsync()
        {
          if ( cuenta == null || _context.Cuenta == null)
            {
                return Page();
            }
        var cliente = await _context.Clientes.FirstOrDefaultAsync(c => c.ClienteId == cuenta.ClienteId);
         if (cliente == null ) { return Page(); }
            var numCuentaRepeido = await _context.Cuenta.FirstOrDefaultAsync(c => c.NumCuenta == cuenta.NumCuenta);
            if (numCuentaRepeido != null ) { return Page(); }

            _context.Cuenta.Add(cuenta);

            /*******************************************************************/
            EstadoCuentum estadoCuenta = new EstadoCuentum();
            estadoCuenta.EstadoCuentaId = cuenta.CuentaId;
            estadoCuenta.CuentaId = cuenta.CuentaId;
            estadoCuenta.NumCuenta = cuenta.NumCuenta;
            estadoCuenta.ClienteId = cuenta.ClienteId;
  
            estadoCuenta.PlazoMeses = 12;
            estadoCuenta.PuntosObtenidos = 0;
            estadoCuenta.PuntosTotales = 0;
            estadoCuenta.FechaCorte = DateOnly.FromDateTime(DateTime.Now.AddDays(90));
            estadoCuenta.FechaMaximaPago = DateOnly.FromDateTime(DateTime.Now.AddDays(30));
            _context.EstadoCuenta.Add(estadoCuenta);
            
            /*******************************************************************/

            await _context.SaveChangesAsync();
            return RedirectToPage("./Cuenta");
        }
    }
}
