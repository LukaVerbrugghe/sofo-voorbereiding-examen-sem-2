using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace prjVoorbereidingExamenSem2.Model
{
    public class Schoolklasse
    {
        private string _school;

        private List<Schoolklasse> _schools;

        public string School { get { return _school; } set { _school = value; } }

        public List<Schoolklasse> Listscholen
        {
            get
            {
                string json = File.ReadAllText("Scholen.json");
                _schools = JsonConvert.DeserializeObject<List<Schoolklasse>>(json);
                return _schools;
            }
            set
            {
                _schools = value;
            }
        }
        public override string ToString()
        {
            return this.School;
        }
    }
}
