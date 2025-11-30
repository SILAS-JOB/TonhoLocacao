using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MercadoPago.Resource.User;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TonhoLocacao.Controllers
{
    public class AccountController : Controller
    {
        private readonly ILogger<AccountController> _logger;
        private readonly UserDbContext _userDbContext;

        public AccountController(ILogger<AccountController> logger, UserDbContext userDbContext)
        {
            _logger = logger;
            _userDbContext = userDbContext;
        }

        public async Task<IActionResult> CreateUser()
        {
            
             
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}