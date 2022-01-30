using System;
using System.Linq;
using System.Threading.Tasks;
using Vehicle.API.Data.Entities;

namespace Vehicle.API.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync ()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckVehiclesTypeAsync();
            await CheckBrandsAsync();
            await CheckDocumentTypesAsync();
            await CheckProceduresAsync();
        }

        private async Task CheckBrandsAsync()
        {
            if (!_context.Brands.Any())
            {
                _context.Brands.Add(new Brand { Description = "Fiat" });
                _context.Brands.Add(new Brand { Description = "Lada" });
                _context.Brands.Add(new Brand { Description = "Susuky" });
                _context.Brands.Add(new Brand { Description = "Chevrolet" });
                _context.Brands.Add(new Brand { Description = "BMW" });
                _context.Brands.Add(new Brand { Description = "VW" });
                _context.Brands.Add(new Brand { Description = "Mercedes Benz" });
                _context.Brands.Add(new Brand { Description = "Honda" });
                _context.Brands.Add(new Brand { Description = "Kawasaky" });
                _context.Brands.Add(new Brand { Description = "Ford" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckProceduresAsync()
        {
            if (!_context.Procedures.Any())
            {
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Alineación" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Lubricación de suspención delantera" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Lubricación de suspención trasera" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Frenos delanteros" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Frenos traseros" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Líquido frenos delanteros" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Líquido frenos traseros" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Calibración de válvulas" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Alineación carburador" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Aceite motor" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Aceite caja" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Filtro de aire" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Sistema eléctrico" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Guayas" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Cambio llanta delantera" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Cambio llanta trasera" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Reparación de motor" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Kit arrastre" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Banda transmisión" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Cambio batería" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Lavado sistema de inyección" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Lavada de tanque" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Cambio de bujia" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Cambio rodamiento delantero" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Cambio rodamiento trasero" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Accesorios" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckDocumentTypesAsync()
        {
            if (!_context.DocumentTypes.Any())
            {
                _context.DocumentTypes.Add(new DocumentType { Description = "DNI" });
                _context.DocumentTypes.Add(new DocumentType { Description = "Pasaporte" });
                _context.DocumentTypes.Add(new DocumentType { Description = "NIT" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckVehiclesTypeAsync()
        {
            if(!_context.VehicleTypes.Any())
            {
                _context.VehicleTypes.Add(new VehicleType { Description = "Auto" });
                _context.VehicleTypes.Add(new VehicleType { Description = "Moto" });
                _context.VehicleTypes.Add(new VehicleType { Description = "Furgo" });
                await _context.SaveChangesAsync();  
            }
        }
    }
}
