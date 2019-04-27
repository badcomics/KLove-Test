using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KLoveTest.Models
{
    public class Employees
{
    [Key]
    public int id { get; set; }
    [Required]
    [DisplayName("First Name")]
    public string FName { get; set; }
    [Required]
    [DisplayName("Last Name")]
    public string LName { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }

    public string Zipcode { get; set; }

    // Foreign Key
    public virtual int DepartmentID { get; set; }

    [ForeignKey("DepartmentID")]
    public virtual Departments Department { get; set; }

}
}
