// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Security.Cryptography.X509Certificates;

namespace Sistema_de_Tarjeta_de_Credito.Areas.Identity.Pages.Account
{
   
    public class LogoutModel : PageModel
    {
        const string galleta = "cookie";
        public async Task<IActionResult> OnPostAsync()
        {
            await HttpContext.SignOutAsync(galleta);
            return RedirectToPage("/Index");
        }
    }
}
