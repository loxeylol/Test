using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class Feuerwache
    {
        public string Name { get; set; }
        public string Adresse { get; set; }
        public string Trivia { get; set; }
        public string Coords { get; set; }
        public int strength { get; set; }
        public Leitstelle leitstelle {get; set;}
        public Inventar inventar { get; set; }
        public string telNr { get; set; }
        

        public override string ToString()
        {
            return this.Name;
        }

        public static List<Feuerwache> GetFireStationList()
        {
            var list = new List<Feuerwache>();

            list.Add(new Feuerwache
            {
                Name = "Freiwilige Feuerwehr Flensburg",
                Adresse = "Flensburg"
            });
            list.Add(new Feuerwache
            {
                Name = "Berufsfeuerwehr Flensburg",
                Adresse = "Flensburg"
            });
            list.Add(new Feuerwache
            {
                Name = " Feuerwehr Apenrade",
                Adresse = "Apenrade"
            });
            list.Add(new Feuerwache
            {
                Name = "Feuerwehr Krusa",
                Adresse = "Krusa"
            });

            return list;
        }

    }
}
