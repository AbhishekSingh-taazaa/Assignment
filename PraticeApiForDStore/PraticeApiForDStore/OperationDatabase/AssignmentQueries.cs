using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PraticeApiForDStore.Entities;
using PraticeApiForDStore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PraticeApiForDStore.OperationDatabase
{
    public class AssignmentQueries
    {
        private DepartmentalStoreContext _context;
        private ILogger<AssignmentQueries> _logger;

        public AssignmentQueries(DepartmentalStoreContext context, ILogger<AssignmentQueries> logger)
        {
            _context = context;
            _logger = logger;
        }
        //Generic Type Add
        public void Add<T>(T enty) where T : class {

            _logger.LogInformation($"Object type {enty.GetType()}");
            _context.Add(enty);
        
        }

        //Generic Type Remove
        public void Remove<T>(T entity) where T : class {

            _logger.LogInformation($"object type {entity.GetType()}");
            _context.Remove(entity);
        }

        //Get All Staff
        public List<Staff> GetAllStaff(bool includeRole = false) {
            _logger.LogInformation($"Get List of Staffs Entity");

            IQueryable<Staff> query = _context.Staff.Include(a => a.Address);

            if (includeRole) {

                query = query.Include(r => r.Role);
            }

            query.OrderByDescending(s => s.Salary);

            return query.ToList();
        }


        //Search Staff by Id

        public Staff GetStaffById(int id, bool includeRole = false) {

            _logger.LogInformation($"Get Staff By Id");

            IQueryable<Staff> query = _context.Staff.Include(a => a.Address);

            if (includeRole) {

                query = query.Include(r => r.Role);
                
            }

            query = query.Where(s => s.Staff_Id == id);

            return query.FirstOrDefault();
        
        
        }

        //Product Queries

        public List<Product> GetAllProduct(bool includePrice = false)
        {
            _logger.LogInformation($"Get List of Product Entity");

            IQueryable<Product> query = _context.Product
                .Include(pc => pc.ProductCategory)
                .Include(i => i.Inventory);

            if (includePrice)
            {

                query = query.Include(pp => pp.ProductPrice);

            }

            query.OrderByDescending(p => p.Manufacturing_Date);

            return query.ToList();
        }

        public Product GetProductByCode(string code, bool includePrice = false) {

            _logger.LogInformation($"Get Product by Code {code}");

            IQueryable<Product> query = _context.Product
                .Include(pc => pc.ProductCategory)
                .Include(i => i.Inventory);

            if (includePrice) {

                query = query.Include(pp => pp.ProductPrice);
            }

            query.Where(x => x.Product_Code == code);

            return query.FirstOrDefault();
        
        }

        public bool saveChangestoDatabase() {

          return  _context.SaveChanges()>0;
        
        }
       
    }
}
