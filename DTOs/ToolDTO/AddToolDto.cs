using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using portfolio.models;

namespace portfolio.DTOs.ToolDTO
{
    public class AddToolDto
    {
        public string name { get; set; }
        public string description { get; set; }
        public string image { get; set; }
        public string link { get; set; }
    }
}