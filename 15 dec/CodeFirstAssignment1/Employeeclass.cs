using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstAssignment1
{
    public class Employeeclass
    {
        [Key]
        [RegularExpression(@"^E\d{3}$",ErrorMessage ="Empid must be in formate E followed by 3 digits")]
        [Column("Empid",TypeName ="varchar")]
        [MaxLength(10)]
        
        public string id {  get; set; }

        [Required(ErrorMessage ="Enter Employee Name")]
        [Column("EmpName", TypeName = "varchar")]
        [MaxLength(20)]
        public string Name {  get; set; }

        [Required(ErrorMessage = "Enter Department Name")]
        [Column("DepartmentName", TypeName = "varchar")]
        [MaxLength(20)]
        public string DeptName {  get; set; }

        [Range(5000,50000,ErrorMessage ="Salary should be between 5000 and 50000")]
        public int Salary {  get; set; }

        [Required]
        [Range(1990,1990,ErrorMessage ="Year should be only 1990")]
        public int Year_Of_Join { get; set; }
    }
}
