using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using PrintersBackend.Models;
using PrintersBackend.Serviceis;
using Microsoft.AspNetCore.Authorization;

namespace PrintersBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrintersController : Controller
    {
        private readonly PrintersService _printersService;
        public PrintersController(PrintersService printersService)
        {
            _printersService = printersService;
        }

        [Authorize]
        [HttpGet]
        public IEnumerable<Printer> Get()
        {
            try
            {
                var printers = _printersService.GetPrinters();
                return printers;
            }
            catch (Exception)
            {
                return null;
            }
        }

        [HttpGet("{id}")]
        public Printer Get(int id)
        {
            return _printersService.GetPrinter(id);
        }

        [HttpPost]
        public int Add(Printer printer)
        {
            return _printersService.AddPrinter(printer);
        }

        [HttpDelete("{id}")]
        public int Remove(int id)
        {
            return _printersService.RemovePrinter(id);
        }

        [HttpPut]
        public void Update(Printer printer)
        {
            _printersService.UpdatePrinter(printer);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
