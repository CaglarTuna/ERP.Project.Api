﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MaterialSupplyStatuDTO : BaseDTO
    {
        public string Name { get; set; }
        public List<MaterialSupplyRequestsDTO> MaterialSupplyRequests { get; set; }
    }
}
