﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace satapi.gateway.data.Models
{
    public class Resource
    {
        public int resourceId { get; set; }
        public string name { get; set; }
        public string uri { get; set; }
        public string version { get; set; }
        public List<Methods> methods { get; set; }
        public string authenticationType { get; set; }
        public DateTime lastHearthbeat { get; set; }
    }
}
