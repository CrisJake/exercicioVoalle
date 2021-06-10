using System;

namespace ExercicioVoalle
{
    class Program
    {
        static void Main(string[] args)
        {
            Tela tela = new Tela();
            Controle controle = new Controle();
            tela.TelaInicial();
            controle.Controlador();
        }
    }
}
