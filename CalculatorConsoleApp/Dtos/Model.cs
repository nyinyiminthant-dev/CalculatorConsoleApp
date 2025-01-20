using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CalculatorConsoleApp.Dtos
{
    [Table("Calculator")]
    public class Model
    {
        [Key]
        public int Id { get; set; }
        public int Result { get; set; }
        public DateTime date { get; set; }
    }

   
}
