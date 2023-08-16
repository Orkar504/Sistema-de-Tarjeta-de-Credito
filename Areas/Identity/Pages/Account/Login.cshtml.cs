// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
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

namespace Sistema_de_Tarjeta_de_Credito.Areas.Identity.Pages.Account
{
    public class LoginModel : PageModel
    {
        public bool hasData = false;
        public int EmpleadoId = 0;
        public string mensaje = "";

        [BindProperty]
        public Credencial Crendencial { get; set; }
        public void onGet()
        {

        }
       
        public class Credencial
        {
            [Required]
            public int EmpleadoId { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }

        }
    }
}
