/*
 * Student ID : 1690701907
 * Name       :viranya phaethong
 * Section    :129c
 * No.        :
 * Course     : GI113 Computer Programming (GI)
 */

using System;

namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("===== BOSS STATUS: INITIAI ====='");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank; {rank}");
            Console.WriteLine($"HP:{currentHp}/{maxHp}");
            Console.WriteLine($"attack power: {attackPower}");
            Console.WriteLine($"Crit Multiplier:{critMultiplier}");
            Console.WriteLine($"Is boss: {isBoss}");

            Console.WriteLine();
            // คำนวนเปอร์เซ็น
            int hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent:{hpPercent}%");
            Console.WriteLine();
            Console.WriteLine($"Kirin takes 60 damage!");
            Console.WriteLine();
            // ลด HP 60 หน่วย
            currentHp = currentHp - 60;
            Console.WriteLine();
            Console.WriteLine("===== BOSS STATUS: after damage =====");
            Console.WriteLine($"HP: {currentHp}/{maxHp}");
            hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent:{hpPercent}%");