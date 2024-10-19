﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chubb.Prueba.Entities.Customer
{
    public class CustomerEntity
    {
        public int CustomerId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Cedula { get; set; }
        public string? Telephone { get; set; }
        public string? Age { get; set; }
        public string? Email { get; set; }
        public int? LegalRepresentId { get; set; }
        public int? StatusId { get; set; }
        public int? UserCreateId { get; set; }
        public DateTime? DateCreate { get; set; }
        public int? UserModificateId { get; set; }
        public DateTime? DateModificate { get; set; }
    }
}
