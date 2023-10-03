using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EjerciciosArays_SAEG.Metodos
{
    public class PrimerosCinco
    {
        public void MostrarArregloDeCincoPosiciones()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        public void IngresarParaLeerEnArray()
        {
            int[] array = new int[5];
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Ingresa la posicion {0} de tu array",i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int j = 0; j < array.Length; j++)
            {
                Console.WriteLine("posicion {0} = {1}",j, array[j]);
            }
        }
        public void MediaDelArreglo()
        {
            int[] array = new int[10];
            double mediaDelArray = 0;
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Ingresa la posicion {0} de tu array", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
                mediaDelArray += array[i];
            }
            Console.WriteLine("la media en el arreglo es de = {0}", mediaDelArray/10);
        }
        public void ArregloAutoCompletado()
        {
            Console.WriteLine("Ingrese de que dimension quiere el arreglo");
            int dimension = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("De que multiplo quieres llenarlo? ");
            int multiplo = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[dimension];
            for(int i = 0; i < array.Length; i++)
            {
                if (i == 0)
                {
                    array[i] = multiplo;
                }
                else
                {
                    array[i] = multiplo * (i + 1);
                }
            }
            for (int j = 0; j < array.Length; j++)
            {
                Console.WriteLine("posicion {0} = {1}", j, array[j]);
            }
        }
        public void NombresConLongitudes()
        {
            Console.WriteLine("Ingresa la Longitud de los arreglos: ");
            int longitud = Convert.ToInt32(Console.ReadLine());
            string[] arrayNombres = new string[longitud];
            int[] arrayLongitudes = new int[longitud];

            for(int i = 0; i < arrayNombres.Length; i++)
            {
                Console.WriteLine("Ingresa el nombre {0}", i + 1);
                arrayNombres[i] = Console.ReadLine();
                arrayLongitudes[i] = arrayNombres[i].Length;
            }
            for (int j = 0; j < arrayNombres.Length; j++)
            {
                Console.WriteLine("El nombre {0} tiene una longitud de: {1} caracteres", arrayNombres[j], arrayLongitudes[j]);
            }
        }
    }
}
