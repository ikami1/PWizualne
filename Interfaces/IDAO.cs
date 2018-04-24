using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galazkiewicz.ProjectTireCatalog.Interfaces
{
    public interface IDAO
    {
        IEnumerable<ITire> GetAllTires();
        IEnumerable<IProducer> GetAllProducers();
    }
}
