using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Logstash4Nlog.Data;

namespace Logstash4Nlog.Controllers
{
    [Route("[controller]/[action]")]
    public class AccountController : Controller
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ILogger _logger;

        public AccountController(SignInManager<ApplicationUser> signInManager, ILogger<AccountController> logger)
        {
            _signInManager = signInManager;
            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.LogDebug("------------------Test Logstash----------------Debug");
            _logger.LogTrace("------------------Test Logstash----------------Trace");
            _logger.LogInformation("------------------Test Logstash----------------Information");
            _logger.LogWarning("------------------Test Logstash----------------Warning");
            _logger.LogError("------------------Test Logstash----------------Error");
            _logger.LogCritical("------------------Test Logstash----------------Critical");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            _logger.LogInformation("User logged out.");
            return RedirectToPage("/Index");
        }
    }
}
