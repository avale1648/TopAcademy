using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AN6cw.Repositories
{
    internal class EmployeeRepository
    {
        public Employee GetByID(int id)
        {
            Employee employee = null;
            using (var db = new Company_DB_PV_113Entities())
            {
                try
                {
                    var res = db.Employee.Where(e => e.EmployeeID == id);
                    if (res != null)
                    {
                        employee = res.First();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return employee;
        }
        public IEnumerable<Employee> GetAll()
        {
            using (var db = new Company_DB_PV_113Entities())
            {
                return db.Employee.ToList();
            }
        }
        public IEnumerable<Employee> GetAll(Expression<Func<Employee,bool>> predicate)
        {
            using (var db = new Company_DB_PV_113Entities())
            {
                var res = db.Employee.Where(predicate);
                return res.ToList();
            }
        }
    }
}
