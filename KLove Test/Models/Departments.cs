using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KLoveTest.Models
{
    public class Departments
{
    [Key]
    public int id { get; set; }
    [Required]
    [DisplayName("Department")]
    public string DepartmentName { get; set; }

    public virtual List<Employees> Employees { get; set; }

}
}
