﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace satapi.gateway.data.Models
{
    public class Methods
    {
        public int methodId { get; set; }
        public string verb { get; set; }
        public string endpoint { get; set; }
        public string parameters { get; set; }
    }
}
