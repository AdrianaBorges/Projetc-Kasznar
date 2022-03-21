﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kasznar.Domain.Models;

namespace Kasznar.Domain.Entities
{
    public class User: Entity 
    {
        public string Name { get; set; }
        public string Email { get; set; }

    }
}
