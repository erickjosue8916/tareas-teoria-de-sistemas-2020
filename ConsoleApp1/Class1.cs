using System;
using System.Collections;

namespace ConsoleApp1
{
    class Menu
    {
        private ArrayList options;
        private int answer = -1;
        public Menu()
        {
            options = new ArrayList();
            Console.WriteLine("menu is ready");
        }

        public void setOptions(String[] opts)
        {
           foreach(String opt in opts)
            {
                options.Add(opt);
            }
        }

        public void showMenu ()
        {
            String msg = "\nEscoge una opcion";
            for (int i = 0; i < options.Count; i++)
            {
                msg += $"\n{i + 1} - {options[i]}";
            }
            msg += "\nSelecciona una opcion: ";
            Console.Write(msg);
            int answer;
            do
            {
                answer = validateAnwer(Console.ReadLine());
            } while (answer < 1 || answer > options.Count);
            
        }

        private int validateAnwer(String answer)
        {
            try
            {
                return int.Parse(answer);
            }catch (Exception e)
            {
                Console.Write("Ingresa una opcion valida: ");
                return validateAnwer(Console.ReadLine());
            }
        }

        public int getAnswer()
        {
            return answer;
        }
    }
}
