using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using HuaweiReg.Service.IServices;
using HuaweiReg.Service.ServiceModels;
using HuaweiReg.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HuaweiReg.Web.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly ILogger<RegistrationController> _logger;
        private readonly IRegistrationService _registrationService;
        private readonly IMapper _mapper;

        public RegistrationController(ILogger<RegistrationController> logger, IRegistrationService registrationService, IMapper mapper)
        {
            _logger = logger;
            _registrationService = registrationService;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(RegistraionViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View(model);

                await _registrationService.AddRegistrationAsync(_mapper.Map<RegistrationModel>(model));
                ViewBag.Message = "Create registration successfully";
                ModelState.Clear();
                return View();
            }
            catch (Exception ex)
            {
                _logger.LogError($"There is an error when creating registration: {ex.Message}");
                ViewBag.Message = "Create registration failed";
                return View(model);
            }
        }
    }
}