// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Numerics;

class Program
{
    static void Main()
    {
        BankTransferConfig config = new BankTransferConfig();
        Console.WriteLine("Select language: en/id");
        string select = Console.ReadLine();

        config.Lang = select;
        if (config.Lang == "en" )
        {
            Console.WriteLine("Please insert the amount of money to transfer:");
            string transferEn = Console.ReadLine();

            if (int.Parse(transferEn) <= config.Transfer.Threshold)
            {
                int total = int.Parse(transferEn) + config.Transfer.LowFee;
            }
            else
            {
                int total = int.Parse(transferEn) + config.Transfer.LowFee;
            }

            Console.WriteLine("Select transfer method: ");
            Console.WriteLine(config.Methods);
            string method = Console.ReadLine();

            Console.WriteLine("Confirmation: ");
            string comfirm = Console.ReadLine();
            if (comfirm == config.Confirmation.En)
            {
                Console.WriteLine("Success");
            }
        }
        else if (config.Lang == "id")
        {
            Console.WriteLine("Masukkan jumlah uang yang akan di-transfer");
            string transferId = Console.ReadLine();

            if (int.Parse(transferId) <= config.Transfer.Threshold)
            {
                int total = int.Parse(transferId) + config.Transfer.LowFee;
            }
            else
            {
                int total = int.Parse(transferId) + config.Transfer.LowFee;
            }

            Console.WriteLine("Select transfer method: ");
            Console.WriteLine(config.Methods);
            string method = Console.ReadLine();

            Console.WriteLine("Confirmation: ");
            string comfirm = Console.ReadLine();
            if (comfirm == config.Confirmation.En)
            {
                Console.WriteLine("Success");
            }
        }

        
    }
}
