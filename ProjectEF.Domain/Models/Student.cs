using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEF.Domain.Models
{
    [Table("students")]
    public class Student
    {
        [Key,Column("id")]
        public int Id { get; set; } 


        [Column("firstname"),MaxLength(30)]
        public string FirstName { get; set; }


        [Column("lastname"), MaxLength(30)]

        public string LastName { get; set; }


        [Column("age")]
        public int Age { get; set; }


        [Column("email"),MaxLength(20)]
        public string Email { get; set; }


        [Column("password"), MaxLength(20)]
        public string Password { get; set; }


        [Column("group_id")]
        public int GroupId { get; set; }

        [ForeignKey(nameof(GroupId))]
        public Group Group { get; set; }

    }
}
