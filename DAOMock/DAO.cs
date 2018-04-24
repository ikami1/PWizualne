using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gałązkiewicz.ProjectTireCatalog.Interfaces;

namespace Gałązkiewicz.ProjectTireCatalog.DAOMock
{
    public class DAO : IDAO
    {
        private List<IProducer> _producers;
        private List<ITire> _tires;

        public DAO()
        {
            _producers = new List<IProducer>()
            {
                new BO.Producer { Name="Continental" },
                new BO.Producer { Name="Maxxis" },
                new BO.Producer { Name="Schwalbe" },
                new BO.Producer { Name="Michelin" }
            };

            _tires = new List<ITire>()
            {
                new BO.Tire { Producer=_producers[0], Model="Mountain King II ProTection", Waga=665, PurposeType=Core.Purpose.MTB },
                new BO.Tire { Producer=_producers[1], Model="Ikon 3C MAXX SPEED/EXO/TR", Waga=585, PurposeType=Core.Purpose.XC },
                new BO.Tire { Producer=_producers[2], Model="Racing Ralph Evo, Lite Skin, PaceStar", Waga=480, PurposeType=Core.Purpose.XC },
                new BO.Tire { Producer=_producers[3], Model="Wild Race'R Advanced Ultimate", Waga=480, PurposeType=Core.Purpose.MTB }
            };
        }

        public IEnumerable<IProducer> GetAllProducers()
        {
            return _producers;
        }

        public IEnumerable<ITire> GetAllTires()
        {
            return _tires;
        }
    }
}
