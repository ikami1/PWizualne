﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Galazkiewicz.ProjectTireCatalog.Interfaces;

namespace Galazkiewicz.ProjectTireCatalog.DAOMock2
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
                new BO.Producer { Name="Schwalbe" },
            };

            _tires = new List<ITire>()
            {
                new BO.Tire { Producer=_producers[0], Model="Mountain King II RaceSport", Waga=575, PurposeType=Core.Purpose.MTB },
                new BO.Tire { Producer=_producers[0], Model="X-King Protection", Waga=595, PurposeType=Core.Purpose.XC },
                new BO.Tire { Producer=_producers[1], Model="Racing Ralph Performance", Waga=535, PurposeType=Core.Purpose.XC },
                new BO.Tire { Producer=_producers[1], Model="Nobby Nic Snake Skin, Pace Star", Waga=635, PurposeType=Core.Purpose.MTB }
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

        public void SaveTire(ITire tire)
        {
            _tires.Add(tire);
        }

        public void SaveTire(ITire tire, int index)
        {
            _tires[index] = tire;
        }

        public ITire AddNewTire()
        {
            return new BO.Tire { Producer = _producers[0], Model = "", Waga = -1, PurposeType = Core.Purpose.MTB };
        }

        public void SaveProducer(IProducer producer)
        {
            _producers.Add(producer);
        }

        public void SaveProducer(IProducer producer, int index)
        {
            _producers[index] = producer;
        }

        public IProducer AddNewProducer()
        {
            IProducer producer = new BO.Producer();
            producer.Name = "";
            return producer;
        }
    }
}
