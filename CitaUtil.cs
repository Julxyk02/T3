using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace T3
{
    internal class CitaUtil{
        public static void crearcita(Cita[] citas, ref int count)
        {
            Console.WriteLine("datos del estudiante:");
            Console.WriteLine("codigo:");
            int codi = int.Parse(Console.ReadLine());
            Console.WriteLine("nombre:");
            string nom = Console.ReadLine();
            Console.WriteLine("universidad:");
            string uni = Console.ReadLine();

            Estudiante estudiante = new Estudiante
            {
                codigo = codi,
                nombre = nom,
                universidad = uni,
            };

            Console.WriteLine("datos de la cita:");
            Console.WriteLine("numero de cita:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("enfermedad:");
            string en = Console.ReadLine();
            Console.WriteLine("precio:");
            double pre = double.Parse(Console.ReadLine());

            citas[count++] = new Cita{
                numero = num,
                estudiante = estudiante,
                enfermedad = en,
                precio = pre,
            };

            Console.WriteLine("Cita creada");
        }
        public static void listarcitas(Cita[] citas, int count){
            double sum = 0;
            Console.WriteLine("Listado de Citas:");
            for (int i = 0; i < count; i++){
                Console.WriteLine(citas[i].ToString());
                sum += citas[i].precio;
            }
            Console.WriteLine($"Suma de todos los precios: {sum}");
        }

        public static void modificar(Cita[] citas, int count)
        {
            Console.Write("Ingrese el texto a buscar en la universidad: ");
            string textoBuscar = Console.ReadLine();
            Console.Write("Ingrese el texto de reemplazo: ");
            string textoReemplazar = Console.ReadLine();

            for (int i = 0; i < count; i++){
                citas[i].estudiante.universidad = citas[i].estudiante.universidad.Replace(textoBuscar, textoReemplazar);
            }
            Console.WriteLine("Modificación realizada");
        }
    }
}
