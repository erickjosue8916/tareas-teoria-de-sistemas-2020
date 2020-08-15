using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CalculoVelocidad
    {
        private double vel;
        private double dist;

        public CalculoVelocidad()
        {
            Calculate();
        }

        public void getData()
        {
            Console.Write("Ingresa la velocidad: ");
            vel = validateNaturalNumber(Console.ReadLine());
            Console.Write("Ingresa la distancia: ");
            dist = validateNaturalNumber(Console.ReadLine());
        }

        private double validateNumber (String number)
        {
            try
            {
                return Double.Parse(number);
            } catch(Exception e) {
                Console.Write("Escribe un numero: ");
                return validateNumber(Console.ReadLine());
            }
        }

        private double validateNaturalNumber(String data)
        {
            Double number = validateNumber(data);

            if (number > 0)
                return number;
            else 
                Console.Write("Escribe un numero mayor a cero: ");
                return validateNaturalNumber(Console.ReadLine());
        }

        public void Calculate()
        {
            getData();
            double answer = Math.Round((dist / vel) * 100) / 100;
            Console.WriteLine($"Si un automovil tiene que recorrer una distancia de {dist} kilometros, si mantiene una velocidad de {vel} km/h, le tomara {answer} h recorrerla");
        }
    }
}
