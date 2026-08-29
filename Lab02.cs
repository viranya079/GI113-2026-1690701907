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

            Console.WriteLine("===== BOSS STATUS: INITIAL ====='");
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

            // ตัวละครที่ 1 Atou Haruki
            string atouName = "Atou";
            char rank = 'B';
            int level = 5;
            int maxHp = 100;
            int currenthp = 50;
            float attackPower = 10.0f;
            double CritMultiplier = 1.5;
            bool isInvestigate = true;

            Console.WriteLine("'===== CHARACTER STATUS: INITIAL====='");
            Console.WriteLine($"Name; {atouName}");
            Console.WriteLine($"Rank; {rank}");
            Console.WriteLine($"HP:{currentHp}/{maxHp}");
            Console.WriteLine($"attack power: {attackPower}");
            Console.WriteLine($"Crit Multiplier:{critMultiplier}");
            Console.WriteLine($"Is boss: {isInvestigate}")

             // ตัวละครที่ 2 Shinanp Eiji
            string shinanoName = "Shinano";
            char rank = 'A';
            int level = 6;
            int maxHp = 100;
            int currenthp = 70;
            float attackPower = 20.0f;
            double CritMultiplier = 2.5;
            bool isCheerup = true;

            Console.WriteLine("'===== CHARACTER STATUS: INITIAL====='");
            Console.WriteLine($"Name; {shinanoName}");
            Console.WriteLine($"Rank; {rank}");
            Console.WriteLine($"HP:{currentHp}/{maxHp}");
            Console.WriteLine($"attack power: {attackPower}");
            Console.WriteLine($"Crit Multiplier:{critMultiplier}");
            Console.WriteLine($"Is boss: {isCheerup}")

             // ตัวละครที่ 3 Reiji Isoi
            string reijiName = "Reiji";
            char rank = 'S';
            int level = 8;
            int maxHp = 100;
            int currenthp = 80;
            float attackPower = 40.0f;
            double CritMultiplier = 4.5;
            bool isFighting = true;

            Console.WriteLine("'===== CHARACTER STATUS: INITIAL====='");
            Console.WriteLine($"Name; {reijiName}");
            Console.WriteLine($"Rank; {rank}");
            Console.WriteLine($"HP:{currentHp}/{maxHp}");
            Console.WriteLine($"attack power: {attackPower}");
            Console.WriteLine($"Crit Multiplier:{critMultiplier}");
            Console.WriteLine($"Is boss: {isFighting}")

            // ตัวละครที่ 4 Kanou Aogu
            string kanouName = "Kanou";
            char rank = 'A';
            int level = 7;
            int maxHp = 100;
            int currenthp = 80;
            float attackPower = 30.0f;
            double CritMultiplier = 3.5;
            bool isStab = true;

            Console.WriteLine("'===== CHARACTER STATUS: INITIAL====='");
            Console.WriteLine($"Name; {kanouName}");
            Console.WriteLine($"Rank; {rank}");
            Console.WriteLine($"HP:{currentHp}/{maxHp}");
            Console.WriteLine($"attack power: {attackPower}");
            Console.WriteLine($"Crit Multiplier:{critMultiplier}");
            Console.WriteLine($"Is boss: {isStab}")
