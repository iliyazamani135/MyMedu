using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace MyMeduDomain.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string NationalCode { get; set; }
        public string PhoneNumber { get; set; }
        public Enum Role { get; set; }
        
      
      // public bool IsStudent() => Role == Role.Student;
      // public bool IsTeacher() => Role == Role.Teacher;
      // public bool IsParent() => Role == Role.Parent;
    }
}
