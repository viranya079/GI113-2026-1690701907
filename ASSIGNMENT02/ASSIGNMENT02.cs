/*
 * Student ID : 1690701907
 * Name       : Viranya Phaethong
 * Section    : 129C
 * No.        : 3
 * Course     : GI113 Computer Programming (GI)
 */
using System;

namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            const string MaterialName = "Iron";
            const double SmeltRate = 0.25;
            const double SalvageRate = 0.30;
            const double MaxBatch = 500.0;

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("--      Welcome to the Forge     --");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("=> Iron Smelting 0.25 / Salvage 0.3");
            Console.WriteLine("=> Key 'S' for Smelt (Ore -> Ingot)");
            Console.WriteLine("=> Key 'B' for Breakdown (Ingot -> Ore)");

            Console.Write("=> Choose Menu: ");
            bool menuValid = char.TryParse(Console.ReadLine(), out char menu);

            Console.Write("=> How much would you like: ");
            bool amountValid = double.TryParse(Console.ReadLine(), out double amount);

            // ตรวจสอบ Amount ก่อน (เงื่อนไขภายนอกใช้ &&)
            if (amountValid && amount > 0 && amount <= MaxBatch)
            {
                
                if (menu == 'S' || menu == 's') 
                {
                    double ingotResult = amount * SmeltRate;
                    Console.WriteLine($"=> {amount:F2} {MaterialName} Ore = {ingotResult:F2} {MaterialName} Ingot");
                }
                else if (menu == 'B' || menu == 'b')
                {
                    double oreResult = amount / SalvageRate;
                    Console.WriteLine($"=> {amount:F2} {MaterialName} Ingot = {oreResult:F2} {MaterialName} Ore");
                }
                else
                {
                    Console.WriteLine("Error: Invalid menu choice. Please choose 'S' or 'B'.");
                }
            }
            else
            {
                Console.WriteLine("Error: Invalid amount. Must be greater than 0 and not exceed 500.");
            }
        }
    }
}