using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LibraryManagement.Controllers
{
    public class ErrorsController : Controller
        
    {
        private readonly ILogger<ErrorsController> logger;

        public ErrorsController(ILogger<ErrorsController> logger)
        {
            this.logger = logger;
        }

        [Route("/Error/{statusCode}")]
        public IActionResult HttpStatusCodeHandler(int statusCode)
        {

            var statusCodeResult = HttpContext.Features.Get<IStatusCodeReExecuteFeature>();
            switch (statusCode)
            {
                case 404:
                    ViewBag.ErrorMessage = " Sorry the error message you requested could not be found";
                    logger.LogInformation($"404 erro occured. Path = {statusCodeResult.OriginalPath}" +
                        $"and QueryingString = {statusCodeResult.OriginalQueryString}");

                    break;
            }

            return View("NotFound");
        }
        [Route("Error")]
        [AllowAnonymous]
        public IActionResult Error()
        {
            var exceptionDetails = HttpContext.Features.Get<IExceptionHandlerPathFeature>();

            logger.LogError($"The Path{exceptionDetails.Path} threw an error " +
                $"{exceptionDetails.Error}");


                 return View("Error");
        }
         
    }
}
