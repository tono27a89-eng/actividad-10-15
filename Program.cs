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
            int ID=1;
            string nombre;
        
            while( ID != 0 ) 
            {


                Console.WriteLine($"Ingrese  ID de empleados, Ingrese 0 para continuar");
                int.TryParse(Console.ReadLine(), out ID);
                if (ID == 0)
                {

                }
                else if (empleados.ContainsKey(ID))
                {
                    Console.WriteLine("valor ya ingresado ingrese otro");
                   
                }
                else
                {
                    Console.WriteLine("ingrese nombre:");
                    nombre = Console.ReadLine();
                    empleados.Add(ID, nombre);

                }

            }
            foreach (var item in empleados)
            {
                Console.WriteLine(" Id:  " + item.Key + "Nombre:  " + item.Value);

            }

        }
    }
}
