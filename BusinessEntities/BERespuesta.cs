using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class BERespuesta
    {
        public BERespuesta()
        {
            success = false;
            total_elements = 0;
            error_code = 0;
            error_msg = string.Empty;
        }
        public int error_code { get; set; }
        public string error_msg { get; set; }

        public object articles { get; set; }
        public object article { get; set; }
        public object stores { get; set; }
        public object store { get; set; }
        public bool success { get; set; }
        public int total_elements { get; set; }
    }
}
