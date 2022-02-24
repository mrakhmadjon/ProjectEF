using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEF.Domain.Models
{
    [Table("groups")]
    public class Group : BaseModel
    {
        [Column("name"), MaxLength(30)]
        public string Name { get; set; }

        [Column("subject_id"), Required]
        public int SubjectId { get; set; }

        [ForeignKey(nameof(SubjectId))]
        public Subject Subject { get; set; }
    }
}
