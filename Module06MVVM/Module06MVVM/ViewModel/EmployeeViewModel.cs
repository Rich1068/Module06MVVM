using Module06MVVM.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.IO;
namespace Module06MVVM.ViewModel
{
    
    public class EmployeeViewModel
    {
/*        public EmployeeModel EmployeeModelSet { get; set; }
        public EmployeeViewModel() 
        {

            EmployeeModelSet = new EmployeeModel
            {
                Id = 1,
                Name = "Juan Dela Cruz",
                Email = "juandelacruz@auf.edu.ph",
                Address = "Angeles City"

            };
        }*/
        private Services.DatabaseContext getContext() 
        {
            return new Services.DatabaseContext();
        }
        public int InsertEmployee(EmployeeModel obj) 
        {
            var _dbContext = getContext();
            _dbContext.Employee.Add(obj);
            int c = _dbContext.SaveChanges();
            return c;
        }
        public async Task<List<EmployeeModel>>GetAllEmployees()
        {
            var _dbContext = getContext();
            var res = await _dbContext.Employee.ToListAsync();
            return res;
        }
    }
}
