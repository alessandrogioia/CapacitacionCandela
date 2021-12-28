using Basics.Helpers;
using Basics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> test = RandomListHelper.Generate(1000, 0, 100);

            var max = MaxMinIntegerHelper.Maxvalue(test);
            var min = MaxMinIntegerHelper.Minvalue(test);
            var repetido = FirstRepeatedHelper.PrimerRepetido(test);
            var b = FirstRepeatedHelper.PrimerRepetidoTempEspacial(test);
            Console.ReadLine();
        }

        public static  void Examples() 
        {
            // Tipos de variables
            string nombre = "ale";
            char _char = 'a';

            // Enteros
            int numero = 10;
            uint numero_positivo = 10;
            long numero_grande = 1000000;

            // Decimales
            float flotante = 1.04F;
            double doble = 1.04;
            decimal _decimal = 1.04M;

            // Booleanos
            bool acepta_terminos_y_condiciones = false;

            // DateTimes
            DateTime date = new DateTime(2002, 1, 2, 14, 36, 54);
            DateTime now = DateTime.Now;
            DateTime today = DateTime.Today;

            // Time Span
            TimeSpan TS_manual = TimeSpan.FromMinutes(14124);
            TimeSpan Date_diff = now - today;
            double total_min = TS_manual.TotalMinutes;

            // GUID
            Guid guid_manual = new Guid("5d256447-7e83-4783-8fed-076d5a3db90f");
            Guid guid_aleatorio = Guid.NewGuid();

            // Nullables
            int? pepe = null;

            // Variables segun asignacion
            var my_number = 10;

            // Clases / Objetos
            Persona person = new Persona();
            person.Birthday = new DateTime(1900, 1, 1);
            person.Name = "Pepe";
            int age = person.GetAge();

            Persona person2 = new Persona(date);
            person2.Name = "Juan";

            Persona person3 = new Persona()
            {
                Name = "Cande",
                Birthday = DateTime.Now,
                Over18 = false
            };

            // List/Arrays
            List<double> list_doubles = new List<double>();
            list_doubles.Add(1.23);
            list_doubles.Add(10);
            list_doubles.Add(0.5123);
            list_doubles.Add(1.23);
            list_doubles.Add(15.489);

            int cantidad = list_doubles.Count();
            double element_0 = list_doubles[0];
            double max_value = list_doubles.Max();
            double min_value = list_doubles.Min();
            double avg_value = list_doubles.Average();
            double sum = list_doubles.Sum();

            List<double> list_doubles2 = new List<double>();
            list_doubles2.Add(1);
            list_doubles2.Add(1.23);

            List<double> intersection = list_doubles.Intersect(list_doubles2).ToList();
            List<double> exceptA = list_doubles.Except(list_doubles2).ToList();
            List<double> exceptB = list_doubles2.Except(list_doubles).ToList();

            list_doubles2.AddRange(list_doubles);
            list_doubles2.RemoveAt(0);
            list_doubles2.Clear();


            List<Persona> invitados = new List<Persona>();
            invitados.Add(person2);
            invitados.Add(person3);
            invitados.Add(person);

            List<Persona> invitados_ordenados_nombre = invitados.OrderBy(n => n.Name).ToList();
            List<Persona> invitados_ordenados_nacimiento_desc = invitados.OrderByDescending(n => n.Birthday).ToList();
            List<Persona> invitados_ordenados_doble = invitados.OrderBy(n => n.Over18).ThenBy(p => p.Birthday).ToList();

            List<Persona> invitados_filtrados = invitados.Where(p => p.Over18 == true).ToList();
            Persona invitados_primero = invitados_ordenados_nombre.First(p => p.Name == "Juan");
            bool existe = invitados.Any(p => p.Name == "Pepe");
            bool todos_cumplen = invitados.All(p => p.Over18);

            var group = invitados.GroupBy(p => p.Over18).Select(q => new
            {
                Over18 = q.Key,
                Count = q.Count(),
                MaxAge = q.Max(p => p.Birthday),
                MinName = q.Min(p => p.Name)
            }).ToList();

            // Operadores

            if (_decimal > 100)
            {
                //your code
            }

            List<int> my_for_list = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                my_for_list.Add(i);
            }

            foreach (var per in invitados)
            {

            }


            while (false)
            {

            }

            int zero = 0;
            try
            {
                int calc = 10 / zero;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
        }
    }
}
