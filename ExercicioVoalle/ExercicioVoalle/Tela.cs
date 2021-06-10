using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioVoalle
{
    class Tela
    {
        Moto moto = new Moto();

        public void TelaInicial()
        {
            int i;
            do
            {
                Console.WriteLine("Escolha 1 para Moto ou 2 para Carro;");
                i = Convert.ToInt32(Console.ReadLine());
            } while (i != 1 && i != 2);
            PrintaNaTela(moto.Velocidade, moto.Marcha);
        }
        public void PrintaNaTela(int velocidade, int marcha)
        {
            Console.Clear();
            Console.WriteLine("Velocidade: " + velocidade + " Km/h");
            Console.WriteLine("Marcha: " + marcha);
            Console.WriteLine("\n\n\nDigite X para aumentar a velocidade");
            Console.WriteLine("Digite Z para diminuir a velocidade");
            Console.WriteLine("Digite C para aumentar a marcha");
            Console.WriteLine("Digite V para diminuir a marcha");
            Console.WriteLine("Digite Esc para fechar o programa");
        }
    }
}
