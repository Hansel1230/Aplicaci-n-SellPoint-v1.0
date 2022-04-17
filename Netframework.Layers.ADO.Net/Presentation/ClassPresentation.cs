using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netframework.Layers.ADO.Net.Presentation
{
    internal class ClassPresentation
    {
        public string OpcionEntidad { get; set; }

        public ClassPresentation(string opcionEntidad)
        {
            OpcionEntidad = opcionEntidad;
        }
    }
}
