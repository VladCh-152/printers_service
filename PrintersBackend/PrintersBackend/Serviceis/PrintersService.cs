using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using PrintersBackend.Models;

namespace PrintersBackend.Serviceis
{
    public class PrintersService
    {
        private readonly PrinterContext _context;
        public PrintersService(PrinterContext context)
        {
            _context = context;
        }
        public List<Printer> GetPrinters()
        {
            return _context.Printers
                .Include(x => x.Model).ThenInclude(x => x.Vendor)
                .Include(x => x.Model).ThenInclude(x => x.Type)
                .ToList();
        }
        public Printer GetPrinter(int id)
        {
            var printer = _context.Printers.FirstOrDefault(x => x.Id == id);

            if (printer == null)
                printer = new Printer();
            return printer;
        }
        public int AddPrinter(Printer printer)
        {
            _context.Printers.Add(printer);
            _context.SaveChanges();
            return printer.Id;
        }
        public void UpdatePrinter(Printer printer)
        {
            _context.Printers.Update(printer);
            _context.SaveChanges();
        }
        public int RemovePrinter(int id)
        {
            Printer printer = GetPrinter(id);
            if (printer != null)
            {
                _context.Printers.Remove(printer);
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
