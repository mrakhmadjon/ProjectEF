using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEF.Domain.Models
{
    [Table("subject")]
    public class Subject : BaseModel
    {
        [Column("name"), Required]
        public string Name { get; set; }
    }
}
