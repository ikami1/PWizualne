using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Galazkiewicz.ProjectTireCatalog.Interfaces;
using System.Reflection;
using System.IO;

namespace Galazkiewicz.ProjectTireCatalog.BLC
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

        public DataProvider(string nazwaBazy)
        {
            var dllFile = new FileInfo(@"..\..\..\" + nazwaBazy + @"\bin\Release\" + nazwaBazy + ".dll");
            Assembly baza = Assembly.LoadFile(dllFile.FullName);

            Type bazaType = baza.GetType("Galazkiewicz.ProjectTireCatalog." + nazwaBazy + ".DAO");
            ConstructorInfo bazaConstructor = bazaType.GetConstructor(new Type[] { });

            DAO = (IDAO) bazaConstructor.Invoke(new object[] { });
        }
    }
}
