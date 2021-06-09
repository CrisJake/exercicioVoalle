using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Voalle
{
    class Program
    {
        static void Main(string[] args)
        {
            Moto moto = new Moto();
            moto.principal();
        }

    }
    public class Moto
    {
        public void principal()
        {
            int velocidade = 0, marcha = 0;
            ConsoleKeyInfo key;
            tela_inicial(velocidade, marcha);
            do
            {
                key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.X)
                {

                    if (marcha >= 1) velocidade = aumenta_velocidade(velocidade, marcha);
                    velocidade = decrementa_velocidade(velocidade, marcha);
                    printa_na_tela(velocidade, marcha);

                }
                if (key.Key == ConsoleKey.Z)
                {

                    velocidade -= 8;
                    if (velocidade < 0) velocidade = 0;
                    printa_na_tela(velocidade, marcha);

                }
                if (marcha != 5)
                {
                    if (key.Key == ConsoleKey.C)
                    {

                        marcha += 1;
                        printa_na_tela(velocidade, marcha);

                    }
                }
                if (marcha != 0)
                {
                    if (key.Key == ConsoleKey.V)
                    {

                        marcha = diminui_marcha(velocidade, marcha);
                        printa_na_tela(velocidade, marcha);

                    }
                }

            } while (key.Key != ConsoleKey.Escape);
        }

        void tela_inicial(int velocidade, int marcha)
        {
            int i;
            do
            {
                Console.WriteLine("Escolha 1 para Moto ou 2 para Carro;");
                i = Convert.ToInt32(Console.ReadLine());
            } while (i != 1 && i != 2);
            printa_na_tela(velocidade, marcha);
        }
        void printa_na_tela(int velocidade, int marcha)
        {
            Console.Clear();
            Console.WriteLine("Velocidade: " + velocidade + " Km/h");
            Console.WriteLine("Marcha: " + marcha);

            Console.WriteLine("\n\n\nDigite X para aumentar a velocidade");
            Console.WriteLine("\nDigite Z para diminuir a velocidade");
            Console.WriteLine("\nDigite C para aumentar a marcha");
            Console.WriteLine("\nDigite V para diminuir a marcha");
            Console.WriteLine("\nDigite Esc para fechar o programa");

        }
        int aumenta_velocidade(int velocidade, int marcha)
        {
            if (velocidade < 20 && marcha >= 1) velocidade += 5;
            if (velocidade < 40 && marcha >= 2) velocidade += 5;
            if (velocidade < 60 && marcha >= 3) velocidade += 5;
            if (velocidade < 80 && marcha >= 4) velocidade += 5;
            if (velocidade < 100 && marcha >= 5) velocidade += 5;
            if (velocidade > 100) velocidade = 100;
            return velocidade;
        }
        int diminui_marcha(int velocidade, int marcha)
        {
            if (((velocidade / 20f) <= 1) && marcha >= 1) marcha -= 1;
            if (((velocidade / 20f) <= 2) && marcha >= 2) marcha -= 1;
            if (((velocidade / 20f) <= 3) && marcha >= 3) marcha -= 1;
            if (((velocidade / 20f) <= 4) && marcha >= 4) marcha -= 1;
            if (((velocidade / 20f) <= 5) && marcha >= 5) marcha -= 1;
            return marcha;
        }
        int decrementa_velocidade(int velocidade, int marcha)
        {
            if (velocidade > 0 && marcha == 0) velocidade -= 2;
            if (velocidade > 20 && marcha == 1) velocidade -= 2;
            if (velocidade > 40 && marcha == 2) velocidade -= 2;
            if (velocidade > 60 && marcha == 3) velocidade -= 2;
            if (velocidade > 80 && marcha == 4) velocidade -= 2;
            if (velocidade < 0) velocidade = 0;

            return velocidade;
        }

    }
}
