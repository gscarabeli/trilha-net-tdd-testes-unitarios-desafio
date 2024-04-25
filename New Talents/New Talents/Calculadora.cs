using System.Collections.Generic;

namespace New_Talents
{
    public class Calculadora
    {

        private List<string> listaHistorico;
        private string data;

        public Calculadora(string data)
        {
            listaHistorico = new List<string>();
            this.data = data;
        }

        public int Somar(int val1, int val2)
        {
            int res = val1 + val2;
            listaHistorico.Insert(0, $"Res: {res} - data: {data}");
            return res;
        }

        public int Subtrair(int val1, int val2)
        {
            int res = val1 - val2;
            listaHistorico.Insert(0, $"Res: {res} - data: {data}");
            return res;
        }

        public int Multiplicar(int val1, int val2)
        {
            int res = val1 * val2;
            listaHistorico.Insert(0, $"Res: {res} - data: {data}");
            return res;
        }

        public int Dividir(int val1, int val2)
        {
            int res = val1 / val2;
            listaHistorico.Insert(0, $"Res: {res} - data: {data}");
            return res;
        }

        public List<string> Historico()
        {
            listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
            return listaHistorico;
        }
    }
}
