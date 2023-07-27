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
    public class PrinterTypesController : Controller
    {
        private readonly PrinterTypesService _printertypesService;
        public PrinterTypesController(PrinterTypesService printerTypesService)
        {
            _printertypesService = printerTypesService;
        }

        [Authorize]
        [HttpGet]
        public IEnumerable<PrinterType> Get()
        {
            try
            {
                var types = _printertypesService.GetTypes();
                return types;
            }
            catch (Exception)
            {
                return null;
            }
        }

        [HttpGet("{id}")]
        public PrinterType Get(int id)
        {
            return _printertypesService.GetType(id);
        }

        [HttpPost]
        public int Add(PrinterType type)
        {
            return _printertypesService.AddType(type);
        }

        [HttpPut]
        public void Update(PrinterType type)
        {
            _printertypesService.UpdateType(type);
        }

        [HttpDelete("{id}")]
        public int Remove(int id)
        {
            return _printertypesService.RemoveType(id);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
