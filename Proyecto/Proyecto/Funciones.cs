using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Proyecto
{
    public class Funciones
    {
        List<User> users = new List<User>();

        public int Numero(int o) // verifica que el input  sea un numero dentro del rango requerido
        {
            int n;
            bool aux0;
            do
            {
                string p;
                p = Console.ReadLine();
                aux0 = int.TryParse(p, out n);
                if (aux0 == false || n > o) { Console.WriteLine("---ERROR: INGRESE SOLO NUMEROS del 1 al {0}---", o); }
            } while (!aux0 || n > o);

            return n;
        }
        public int Acceso_inicial() // verifica que el input  sea un numero dentro del rango requerido
        {
            int n;
            bool aux1 = true;
            bool aux2 = true;
            do{
                aux2 = int.TryParse(Console.ReadLine(), out n);
                if (n == 1) { aux1 = false; }
                else if (n == 2) { aux1 = false; }
                else if (n == 3) { aux1 = false; }
                else if (n == 202023) { aux1 = false; }
                else { Console.WriteLine("---ERROR: INGRESE SOLO NUMEROS del 1 al {0}---", 3); }
            } while (aux1);
            return n;
        }

        public void Crear_cantante(){
            Console.WriteLine("Ingrese el nombre:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el Apellido:");
            string apellido = Console.ReadLine();
            Console.WriteLine("Ingrese la edad:");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nacionalidad:");
            string nacion = Console.ReadLine();     
            Console.WriteLine("Ingrese la Genero:");
            string genero = Console.ReadLine();
            Artista cantante = new Artista(nombre, apellido, edad, genero, nacion);
            foreach (Artista cant in ALAINID.lista_cantantes){
                if (cant  == cantante){
                    Console.WriteLine("Este cantante ya existe");
                }
            }
            ALAINID.lista_cantantes.Add(cantante);
        }

        public void Crear_compositor()
        {
            Console.WriteLine("Ingrese el nombre:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el Apellido:");
            string apellido = Console.ReadLine();
            Console.WriteLine("Ingrese la edad:");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nacionalidad:");
            string nacion = Console.ReadLine();
            Console.WriteLine("Ingrese la Genero:");
            string genero = Console.ReadLine();
            Artista compositor = new Artista(nombre, apellido, edad, genero, nacion);
            foreach (Artista cant in ALAINID.lista_compositores){
                if (cant == compositor){
                    Console.WriteLine("Este compositor ya existe");
                }
            }
            ALAINID.lista_compositores.Add(compositor);
        }
        
        public void Crear_()
        {
            Console.WriteLine("Ingrese el nombre:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el Apellido:");
            string apellido = Console.ReadLine();
            Console.WriteLine("Ingrese la edad:");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nacionalidad:");
            string nacion = Console.ReadLine();
            Console.WriteLine("Ingrese la Genero:");
            string genero = Console.ReadLine();
            Artista compositor = new Artista(nombre, apellido, edad, genero, nacion);
            foreach (Artista cant in ALAINID.lista_compositores)
            {
                if (cant == compositor)
                {
                    Console.WriteLine("Este compositor ya existe");
                }
            }
            ALAINID.lista_compositores.Add(compositor);
        }

    }
}