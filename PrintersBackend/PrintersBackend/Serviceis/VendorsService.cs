using System.Collections.Generic;
using System.Linq;
using PrintersBackend.Models;

namespace PrintersBackend.Serviceis
{
    public class VendorsService
    {
        private readonly PrinterContext _context;
        public VendorsService(PrinterContext context)
        {
            _context = context;
        }
        public List<Vendor> GetVendors()
        {
            return _context.Vendors.ToList();
        }
        public Vendor GetVendor(int id)
        {
            var vendor = _context.Vendors.FirstOrDefault(x => x.Id == id);

            if (vendor == null)
                vendor = new Vendor();

            return vendor;
        }
        public int AddVendor(Vendor vendor)
        {
            _context.Vendors.Add(vendor);
            _context.SaveChanges();
            return vendor.Id;
        }
        public void UpdateVendor(Vendor vendor)
        {
            _context.Vendors.Update(vendor);
            _context.SaveChanges();
        }
        public int RemoveVendor(int id)
        {
            Vendor vendor = GetVendor(id);
            if (vendor != null)
            {
                _context.Vendors.Remove(vendor);
                _context.SaveChanges();
                return id;
            }
            else
            {
                return -1;
            }
        }
    }
}
