using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Galazkiewicz.ProjectTireCatalog.Core;

namespace Galazkiewicz.ProjectTireCatalog.Interfaces
{
    public interface ITire
    {
        IProducer Producer { get; set; }
        string Model { get; set; }
        double Waga { get; set; }
        Purpose PurposeType { get; set; }
    }
}
