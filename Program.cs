/*
* Student ID : 1690701907
* Name       :viranya phaethong
* Section    :129c
* No.        :
* Course     : GI113 Computer Programming (GI)
*/

namespace LAB03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MaxLevel = 10;

            var bossName = "Kirin";  //ต้องประกาศด้วย var ห้ามเขียน string ตรงๆ
            var rank = 'S';          //ต้องประกาศด้วย var ห้ามเขียน char ตรงๆ
            int level = 7;
            int maxHp = 240;
            int currentHp = 115;    //คำสั่งต้นของ Lab นี้คือ HP "พลังโดนโจมตี" จาก Lab 2 แล้ว ไม่ใช่ 175
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("===== KIRIN SAVE CONVERTER =====");
            Console.WriteLine($"Name: {bossName})" +
                $"\nRank: {rank}" +
                $"\nLevel: {level}/{MaxLevel}" +
                $"\nHP: {currentHp}/{maxHp}" +
                $"\nattack Power: {attackPower}" +
                $"\nCrit Mutiplier: {critMultiplier}" +
                $"$\nIs Boss: {isBoss}");

            //1.Implicit Convaersion int (Hp) -->> double
            Console.WriteLine("\n----- Implicit Conversion: HP as double -----");
            double currentHpDouble = currentHp;
            Console.WriteLine($"HP (doble): {currentHpDouble}");

            //2.Calculate Percentage
            Console.WriteLine("\n----- Exact HP Percent (no integer truncation) -----");
            double hpPercentExact = currentHpDouble = 100 / maxHp;
            Console.WriteLine($"HP Percent (Exact): {hpPercentExact}");

            //3.Explicit float (attactPower) -->> int
            Console.WriteLine("\n----- Explicit float: attackPower as int -----");
            double attackPowerintCast = (int)attackPower;
            Console.WriteLine($"Attack Power (int cast): {attackPowerintCast}");

            //4.Cast vs. Convert double (criMultiplier) -->> int
            Console.WriteLine("\n-----Cast vs. Convert: criMultiplier -----");
            int critMultiplierIntCast = (int)critMultiplier;
            Console.WriteLine($"Critt Multiplier (int cast): {critMultiplierIntCast}");
            int critiplierConvertRounded = Convert.ToInt32(critMultiplier);
            Console.WriteLine($"Cast Multiplier (convert Rounded): {critiplierConvertRounded}");
        }
    }
}