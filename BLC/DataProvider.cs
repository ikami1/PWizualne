using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gałązkiewicz.ProjectTireCatalog.Interfaces;
using System.Reflection;
using System.IO;

namespace Gałązkiewicz.ProjectTireCatalog.BLC
{
    public class DataProvider
    {
        public IDAO DAO { get; set; }
        public IEnumerable<ITire> Tires
        {
            get { return DAO.GetAllTires(); }
        }
        public IEnumerable<IProducer> Producers
        {
            get { return DAO.GetAllProducers(); }
        }

        public DataProvider(string nazwa_bazy)
        {
            var dllFile = new FileInfo(@"..\..\..\" + nazwa_bazy + @"\bin\Release\" + nazwa_bazy + ".dll");
            Assembly baza = Assembly.LoadFile(dllFile.FullName);

            Type bazaType = baza.GetType("Gałązkiewicz.ProjectTireCatalog." + nazwa_bazy + ".DAO");
            ConstructorInfo bazaConstructor = bazaType.GetConstructor(new Type[] { });

            DAO = (IDAO) bazaConstructor.Invoke(new object[] { });
        }
    }
}
