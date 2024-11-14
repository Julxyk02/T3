using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    internal class Estudiante{
        public int codigo {  get; set; }
        public string nombre { get; set; }
        public string universidad { get; set; }
        public override string ToString(){
            return $"Codigo: {codigo}, Numbre: {nombre}, Univerdiad: {universidad}";
        }
    }
}
