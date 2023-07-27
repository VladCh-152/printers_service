using System.Collections.Generic;
using System.Linq;
using PrintersBackend.Models;

namespace PrintersBackend.Serviceis
{
    public class PrinterTypesService
    {
        private readonly PrinterContext _context;
        public PrinterTypesService(PrinterContext context)
        {
            _context = context;
        }
        public List<PrinterType> GetTypes()
        {
            return _context.Types.ToList();
        }
        public PrinterType GetType(int id)
        {
            var type = _context.Types.FirstOrDefault(x => x.Id == id);

            if (type == null)
                type = new PrinterType();
            return type;
        }
        public int AddType(PrinterType type)
        {
            _context.Types.Add(type);
            _context.SaveChanges();
            return type.Id;
        }
        public void UpdateType(PrinterType type)
        {
            _context.Types.Update(type);
            _context.SaveChanges();
        }
        public int RemoveType(int id)
        {
            PrinterType type = GetType(id);
            if (type != null)
            {
                _context.Types.Remove(type);
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
