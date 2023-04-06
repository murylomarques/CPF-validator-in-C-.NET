using System;

namespace ValidadorCPF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o CPF a ser validado");
            string cpf = Console.ReadLine();

            if (ValidarCPF(cpf))
            {
                Console.WriteLine("CPF válido!");
            }
            else
            {
                Console.WriteLine("CPF inválido!");
            }

            Console.ReadKey();
        }

        static bool ValidarCPF(string cpf)
        {
            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Length != 11)
            {
                return false;
            }

            bool numerosRepetidos = true;

            for (int i = 1; i < cpf.Length; i++)
            {
                if (cpf[i] != cpf[0])
                {
                    numerosRepetidos = false;
                    break;
                }
            }

            if (numerosRepetidos)
            {
                return false;
            }

            int[] pesos = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma = 0;

            for (int i = 0; i < pesos.Length; i++)
            {
                soma += pesos[i] * int.Parse(cpf[i].ToString());
            }

            int resto = soma % 11;

            int primeiroDigitoVerificador = resto < 2 ? 0 : 11 - resto;

            if (int.Parse(cpf[9].ToString()) != primeiroDigitoVerificador)
            {
                return false;
            }

            pesos = new int[] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            soma = 0;

            for (int i = 0; i < pesos.Length; i++)
            {
                soma += pesos[i] * int.Parse(cpf[i].ToString());
            }

            resto = soma % 11;

            int segundoDigitoVerificador = resto < 2 ? 0 : 11 - resto;

            if (int.Parse(cpf[10].ToString()) != segundoDigitoVerificador)
            {
                return false;
            }

            return true;
        }
    }
}
