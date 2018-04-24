using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gałązkiewicz.ProjectTireCatalog.Core;
using Gałązkiewicz.ProjectTireCatalog.Interfaces;

namespace Gałązkiewicz.ProjectTireCatalog.DAOMock2.BO
{
    public class Tire : ITire
    {
        public IProducer Producer { get; set; }
        public string Model { get; set; }
        public double Waga { get; set; }
        public Purpose PurposeType { get; set; }
    }
}
