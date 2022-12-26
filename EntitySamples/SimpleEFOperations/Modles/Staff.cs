using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleEFOperations.Modles
{
    public class Staff
    {
        [Key]
        public virtual string Email { get; set; }
        public virtual DateTime Hire_Date { get; set; }

        public override string ToString()
        {
            return $"Email : [{Email}] , HireDate [{Hire_Date.ToString()}]]";
        }
    }
}
