using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.ViewModel
{
    [DisplayName("Stores")]
    public class BEStore
    {
        public short id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
    }
}
