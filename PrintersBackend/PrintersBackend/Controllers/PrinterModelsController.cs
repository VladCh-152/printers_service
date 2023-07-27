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
    public class PrinterModelsController : Controller
    {
        private readonly PrinterModelsService _printermodelsService;
        public PrinterModelsController(PrinterModelsService printerModelsService)
        {
            _printermodelsService = printerModelsService;
        }

        [Authorize]
        [HttpGet]
        public IEnumerable<PrinterModel> Get()
        {
            try
            {
                var models = _printermodelsService.GetModels();
                return models;
            }
            catch (Exception)
            {
                return null;
            }
        }

        [HttpGet("{id}")]
        public PrinterModel Get(int id)
        {
            return _printermodelsService.GetModel(id);
        }

        [HttpPost]
        public int Add(PrinterModel model)
        {
            return _printermodelsService.AddModel(model);
        }

        [HttpPut]
        public void Update(PrinterModel model)
        {
            _printermodelsService.UpdateModel(model);
        }

        [HttpDelete("{id}")]
        public int Remove(int id)
        {
            return _printermodelsService.RemoveModel(id);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
