using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleEFOperations.Modles
{
    [Keyless]
    class Animal
    {
        public virtual string Name { get; set; }
        public virtual string Species { get; set; }
        public virtual string Primary_Color { get; set; }
        public virtual Guid Implant_Chip_ID { get; set; }
        public virtual string Breed { get; set; }
        public virtual string Gender { get; set; }
        public virtual DateTime Birth_Date { get; set; }
        public virtual string Pattern { get; set; }
        public virtual DateTime Admission_Date { get; set; }

        public override string ToString()
        {
            return $"Name :[{Name}], Species : [{Species}]";
        }
        //public Animal(string Name_, string Species_, string Primary_Color_, Guid Implant_Chip_ID_, string Breed_, string Gender_, DateTime Birth_Date_, string Pattern_, DateTime Admission_Date_)
        //{
        //    this.Name = Name_;
        //    this.Species = Species_;
        //    this.Primary_Color = Primary_Color_;
        //    this.Implant_Chip_ID = Implant_Chip_ID_;
        //    this.Breed = Breed_;
        //    this.Gender = Gender_;
        //    this.Birth_Date = Birth_Date_;
        //    this.Pattern = Pattern_;
        //    this.Admission_Date = Admission_Date_;
        //}
    }
}
