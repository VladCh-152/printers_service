using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using PrintersBackend.Models;

namespace PrintersBackend.Serviceis
{
    public class PrinterModelsService
    {
        private readonly PrinterContext _context;
        public PrinterModelsService(PrinterContext context)
        {
            _context = context;
        }
        public List<PrinterModel> GetModels()
        {
            return _context.Models
                .Include(x => x.Vendor)
                .Include(x => x.Type)
                .ToList();
        }
        public PrinterModel GetModel(int id)
        {
            var model = _context.Models.FirstOrDefault(x => x.Id == id);

            if (model == null)
                model = new PrinterModel();
            return model;
        }
        public int AddModel(PrinterModel model)
        {
            _context.Models.Add(model);
            _context.SaveChanges();
            return model.Id;
        }
        public void UpdateModel(PrinterModel model)
        {
            _context.Models.Update(model);
            _context.SaveChanges();
        }
        public int RemoveModel(int id)
        {
            PrinterModel model = GetModel (id);
            if (model != null)
            {
                _context.Models.Remove(model);
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
