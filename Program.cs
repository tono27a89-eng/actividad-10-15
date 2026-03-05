using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace actividad_10_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cree un diccionario de empleados y muestre un mensaje con el siguiente formato:\r\nID: ___ Nombre: ___");
            Dictionary<int, string> empleados=new Dictionary<int, string>();
            int ID;
            string nombre;
        
            while( ID != 0 ) 
            {


                Console.WriteLine($"Ingrese  ID NO.{i + 1} de empleados, mientras que no sea 0 continuara");
                int.TryParse(Console.ReadLine(), out clave);
                if (producto.ContainsKey(clave))
                {
                    Console.WriteLine("valor ya ingresado ingrese otro");
                    i--;

                }
                else
                {
                    Console.WriteLine("ingrese nombre:");
                    nombre = Console.ReadLine();
                    producto.Add(clave, nombre);

                }

            }
            foreach (var item in producto)
            {
                Console.WriteLine("prodcuto Id: " + item.Key + "valor: " + item.Value);

            }

        }
    }
}
