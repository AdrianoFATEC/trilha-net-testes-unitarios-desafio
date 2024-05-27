using System.Collections.Generic;

namespace TestesUnitarios.Desafio.Console.Services
{
    public class ValidacoesLista
    {
        public List<int> RemoverNumerosNegativos(List<int> lista)
        {
            var resultado = new List<int>();
            foreach (var numero in lista)
            {
                if (numero >= 0)
                {
                    resultado.Add(numero);
                }
            }
            return resultado;
        }

        public bool ListaContemDeterminadoNumero(List<int> lista, int numero)
        {
            return lista.Contains(numero);
        }

        public List<int> MultiplicarElementosPorDois(List<int> lista)
        {
            var resultado = new List<int>();
            foreach (var item in lista)
            {
                resultado.Add(item * 2);
            }
            return resultado;
        }

        public int RetornarMaiorNumeroLista(List<int> lista)
        {
            int max = int.MinValue;
            foreach (var numero in lista)
            {
                if (numero > max)
                {
                    max = numero;
                }
            }
            return max;
        }

        public int RetornarMenorNumeroLista(List<int> lista)
        {
            int min = int.MaxValue;
            foreach (var numero in lista)
            {
                if (numero < min)
                {
                    min = numero;
                }
            }
            return min;
        }
    }
}
