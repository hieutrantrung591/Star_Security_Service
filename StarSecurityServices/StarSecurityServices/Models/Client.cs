﻿using System;
using System.Collections.Generic;

#nullable disable

namespace StarSecurityServices.Models
{
    public partial class Client
    {
        public Client()
        {
            ClientServices = new HashSet<ClientService>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual ICollection<ClientService> ClientServices { get; set; }
    }
}