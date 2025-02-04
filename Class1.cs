using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Clase1
{
    public class Ave
    {

        public string? Nombre {  get; set; }
        public string? especie { get; set; }
        public string? color { get; set; }
        public double? tamano { get; set; }

        public string? habitat {  get; set; }

        public void imprimir()
        {
            Console.WriteLine($"Nombre:{Nombre}");
            Console.WriteLine($"Nombre:{especie}");
            Console.WriteLine($"Nombre:{color}");
            Console.WriteLine($"Nombre:{tamano}cm");
            Console.WriteLine($"Nombre:{habitat}");
        }
    }
}
