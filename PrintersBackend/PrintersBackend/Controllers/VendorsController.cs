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
    public class VendorsController : Controller
    {
        private readonly VendorsService _vendorsService;
        public VendorsController(VendorsService vendorsService)
        {
            _vendorsService = vendorsService;
        }

        [Authorize]
        [HttpGet]
        public IEnumerable<Vendor> Get()
        {
            try
            {
                var vendors = _vendorsService.GetVendors();
                return vendors;
            }
            catch (Exception)
            {
                return null;
            }
        }

        [HttpGet("{id}")]
        public Vendor Get(int id)
        {
            return _vendorsService.GetVendor(id);
        }

        [HttpPost]
        public int Add(Vendor vendor)
        {
            return _vendorsService.AddVendor(vendor);
        }

        [HttpPut]
        public void Update(Vendor vendor)
        {
            _vendorsService.UpdateVendor(vendor);
        }

        [HttpDelete("{id}")]
        public int Remove(int id)
        {
            return _vendorsService.RemoveVendor(id);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
