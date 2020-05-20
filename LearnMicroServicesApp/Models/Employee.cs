using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace LearnMicroServicesApp.Models
{
    [Table("Employee", Schema = "dbo")]
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
       // [Display(Name = "Employee ID")]
        public int EmployeeID { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
       // [Display(Name = "Employee FirstName")]
        public string EmployeeFirstName { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        //[Display(Name = "Employee LastName")]
        public string EmployeeLastName { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string Gender { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Designation { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Department { get; set; }
        
    }

}
