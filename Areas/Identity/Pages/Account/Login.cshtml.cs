// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

//Basado en el código de Frank Liu en su canal de youtube : https://www.youtube.com/@FrankLiuSoftware

//Co-author = Orkar504
//Jose Martinez
//20191031721
#nullable disable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Net;
using System.Security.Claims;


namespace Sistema_de_Tarjeta_de_Credito.Areas.Identity.Pages.Account
{
    public class LoginModel : PageModel
    {
        const string galleta = "cookie";//para crear una cookies

        [BindProperty]
        public Credencial crendencial { get; set; }
        public void onGet()
        {
            
        }


      
        public async Task<IActionResult>  OnPostAsync()
        
        {
            if (!ModelState.IsValid) return Page();
            //Este es un ejemplo de como se debería de hacer la verificación con diferentes usuarios
            if(crendencial.EmpleadoId =="admin" && crendencial.Password =="contrasena")
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,"admin")
                    
                };
                var indentidad = new ClaimsIdentity(claims, galleta);

                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(indentidad);

               await HttpContext.SignInAsync(galleta, claimsPrincipal);

                return RedirectToPage("/Index"); // Redirige al Index
            }
            return Page();// Reinicia la página
        } 
        public class Credencial
        {
            [Required]
            [Display (Name = "ID del Empleado")]
            public string EmpleadoId { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }

        }
       
    }
}
