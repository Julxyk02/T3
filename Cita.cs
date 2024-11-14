using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace T3
{
    internal class Cita{
        public int numero {  get; set; }
        public Estudiante estudiante { get; set; }  
        public string enfermedad {  get; set; }
        public double precio { get; set; }
        public override string ToString(){
            return $"Numero: {numero}, Enfermedad: {enfermedad}, Estudiante: {estudiante.nombre}, Universidad: {estudiante.universidad}, Precio: {precio}";
        }
    }
}
