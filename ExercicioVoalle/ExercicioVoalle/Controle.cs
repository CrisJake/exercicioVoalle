using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioVoalle
{
    class Controle
    {
        public ConsoleKeyInfo key { get; set; }
        Moto moto = new Moto();
        Tela tela = new Tela();

        public void Controlador()
        {
            do
            {
                key = Console.ReadKey();

                if (key.Key == ConsoleKey.X)
                {

                    if (moto.Marcha >= 1) moto.Velocidade = moto.AumentaVelocidade(moto.Velocidade, moto.Marcha);
                    moto.Velocidade = moto.DecrementaVelocidade(moto.Velocidade, moto.Marcha);
                    tela.PrintaNaTela(moto.Velocidade, moto.Marcha);

                }
                if (key.Key == ConsoleKey.Z)
                {

                    moto.Velocidade -= 8;
                    if (moto.Velocidade < 0) moto.Velocidade = 0;
                    tela.PrintaNaTela(moto.Velocidade, moto.Marcha);

                }
                if (moto.Marcha != 5)
                {
                    if (key.Key == ConsoleKey.C)
                    {

                        moto.Marcha += 1;
                        tela.PrintaNaTela(moto.Velocidade, moto.Marcha);

                    }
                }
                if (moto.Marcha != 0)
                {
                    if (key.Key == ConsoleKey.V)
                    {

                        moto.Marcha = moto.DiminuiMarcha(moto.Velocidade, moto.Marcha);
                        tela.PrintaNaTela(moto.Velocidade, moto.Marcha);

                    }
                }
            } while (key.Key != ConsoleKey.Escape);
        }
    }
}
