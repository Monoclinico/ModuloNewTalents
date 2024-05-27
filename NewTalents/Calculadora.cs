using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewTalents
{
    public class Calculadora
    {
        private List<string> historico;
        private string data;

        public Calculadora(string data){
            this.historico = new List<string>();
            this.data = data;
        }

        public int Somar(int a, int b){
            int res = a + b;
            historico.Insert(0,"Res:"+ res + " - data: " + data);
            return res;
        }
        public int Subtrair(int a, int b){
            int res = a - b;
            historico.Insert(0,"Res:"+ res + " - data: " + data);
            return res;
        }
        public int Multiplicar(int a, int b){
            int res = a * b;
            historico.Insert(0,"Res:"+ res + " - data: " + data);
            return res;
        }
        public int Dividir(int a, int b){
            int res = a / b;
            historico.Insert(0,"Res:"+ res + " - data: " + data);
            return res;
        }

        public List<string> Historico(){

            historico.RemoveRange(3,historico.Count-3);
            return historico;
        }
    }
}

