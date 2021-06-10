using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioVoalle
{
    public class Moto
    {
        public int Velocidade { get; set; }
        public int Marcha { get; set; }

        public int AumentaVelocidade(int velocidade, int marcha)
        {
            if (velocidade < 20 && marcha >= 1) velocidade += 5;
            if (velocidade < 40 && marcha >= 2) velocidade += 5;
            if (velocidade < 60 && marcha >= 3) velocidade += 5;
            if (velocidade < 80 && marcha >= 4) velocidade += 5;
            if (velocidade < 100 && marcha >= 5) velocidade += 5;
            if (velocidade > 100) velocidade = 100;
            return velocidade;
        }
        public int DiminuiMarcha(int velocidade, int marcha)
        {
            if (((velocidade / 20f) <= 1) && marcha >= 1) marcha -= 1;
            if (((velocidade / 20f) <= 2) && marcha >= 2) marcha -= 1;
            if (((velocidade / 20f) <= 3) && marcha >= 3) marcha -= 1;
            if (((velocidade / 20f) <= 4) && marcha >= 4) marcha -= 1;
            if (((velocidade / 20f) <= 5) && marcha >= 5) marcha -= 1;
            return marcha;
        }
        public int DecrementaVelocidade(int velocidade, int marcha)
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