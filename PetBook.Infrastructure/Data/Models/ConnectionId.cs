﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetBook.Infrastructure.Data.Models
{
    public class ConnectionId
    {
        [Key]
        public int Id { get; set; }

        public string Value { get; set; }
    }
}
