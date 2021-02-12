using System;

namespace TesteVillela
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            int numberOfBills = 0;
            int[] differentBillsUsed = new int[] { 100, 50, 20, 10, 5, 2, 1 };

            //getting the value to change for the bills
            Console.WriteLine("Digite um numero inteiro");
            int value = ReadValue(Console.ReadLine());


            Console.WriteLine("Para completar o valor de R$"+ value);

            for (int i = 0; i < differentBillsUsed.Length; i++)
            {
                //paying with each bill, from biggest to smallest value
                payMoney(ref value, ref numberOfBills, differentBillsUsed[i]);
            }

            Console.WriteLine("É preciso de " + numberOfBills+ " cédulas ");
            Console.ReadLine();
        }

        static int ReadValue(string valueStr)
        {
            int value;
            Console.Clear();
            if (int.TryParse(valueStr, out value))
            {
                return value;
            }
            else
            {
                Console.WriteLine("Digita um valor correto");
                return ReadValue(Console.ReadLine());
            }
        }

        static void payMoney(ref int remainingValue, ref int numberOfBills, int billAmount)
        {
            while (remainingValue >= billAmount)
            {
                remainingValue -= billAmount;
                numberOfBills++;
            }
        }
    }
}
