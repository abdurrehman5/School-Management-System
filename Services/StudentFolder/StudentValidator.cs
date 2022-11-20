using Data.Entities;
using Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Services.StudentFolder
{
    public abstract class StudentValidator
    {
        public StudentValidator(Student student)
        {
            // no longer needed
            //AddEmptyRuleFor(x => x.LastName, "Last Name is a required field!");
            //AddEmptyRuleFor(x => x.FirstName, "First Name is a required field!");
            //AddEmptyRuleFor(x => x.MiddleName, "Middle Name is a required field!");
        }
    }
}
