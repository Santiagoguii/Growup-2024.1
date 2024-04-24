using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Crud_usuarios.Models
{
    public class User
    {
        [Key]
        public string CPF { get; set; }
        public string Name { get; set; }
        public string Telephone { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Neighborhood { get; set; }
        public string Street { get; set; }
        public string ResidenceNumber { get; set; }
    }
}
