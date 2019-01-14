using System;
using System.Collections.Generic;
namespace CBingo
{
    public class Bombo
    {
        private IList<int> bolasSacadas=new List<int>();
        private Random random = new Random();
        public Bombo()
        {
            for (int bola = 1; bola <= 90;bola++){
                bolasSacadas.Add(bola);

            }
        }
        public int sacarBola(){
            int indexAleatorio = random.Next(bolasSacadas.Count);
            int bola = bolasSacadas[indexAleatorio];
            bolasSacadas.RemoveAt(indexAleatorio);
            return bola;
        }
        public bool quedanBolas(){
            return bolasSacadas.Count > 0;
        }
    }
}
