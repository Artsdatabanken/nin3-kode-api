using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiN3.Core.Models
{
    public class VariabelnavnMaaleskalaTrinn
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // added attribute to auto-generate Id
        public int Id { get; set; }
        public Variabelnavn Variabelnavn { get; set; }
        //public Maaleskala maaleskala { get; set; }
        public Maaleskala Maaleskala { get; set; }
        public Trinn Trinn { get; set; }
    }
}
