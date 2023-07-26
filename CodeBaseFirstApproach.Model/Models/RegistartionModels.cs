using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBaseFirstApproach.Model.Models
{
    public class RegistartionModels
    {

        [Key]
        public int id { get; set; }

        [Column("Fullname", TypeName = "varchar(50)")]
        public string? Fullname { get; set; }



        [Column("Email",TypeName ="varchar(50)")]
        public string? Email { get; set; }


        [Column("Password",TypeName ="varchar(50)")]
        public string? Password { get; set; }


        [Column("Phonenumber",TypeName ="varchar(50)")]
        public string? Phonenumber { get; set; }

        public int Standard { get; set; }

    }
}
