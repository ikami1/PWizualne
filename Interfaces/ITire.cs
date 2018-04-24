using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gałązkiewicz.ProjectTireCatalog.Core;

namespace Gałązkiewicz.ProjectTireCatalog.Interfaces
{
    public interface ITire
    {
        IProducer Producer { get; set; }
        string Model { get; set; }
        double Waga { get; set; }
        Purpose PurposeType { get; set; }
    }
}
