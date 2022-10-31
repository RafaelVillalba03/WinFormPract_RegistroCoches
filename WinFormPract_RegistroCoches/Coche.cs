using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormPract_RegistroCoches
{
    public class Coche
    {
        public int? Id { get; set; }

        public string marca { get; set; }

        public DateTime? fechaFabricacion { get; set; }

        public string coste { get; set; }
    }
}
