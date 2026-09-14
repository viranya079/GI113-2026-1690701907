/*
* Student ID : 1690701907
* Name       :viranya phaethong
* Section    :129c
* No.        :
* Course     : GI113 Computer Programming (GI)
*/

namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string GameTitle = "Cell of mirage";

            var adventurerName = "Otowa rui";
            var adventurerRank = 'B';
            int adventurerLevel = 5;
            float slashDamage = 5.0;
            double staminaPrecise = 85.5;
            bool isPlayable = true;

            Console.WriteLine($"===== {GameTitle} =====");
            Console.WriteLine($"Adventurer Name   : {adventurerName}");
            Console.WriteLine($"Rank        : {adventurerRank}");
            Console.WriteLine($"Level       : {adventurerLevel}");
            Console.WriteLine($"Crit Chance : {slashDamage}");
            Console.WriteLine($"Stamina     : {staminaPrecise}");
            Console.WriteLine($"Playable    : {isPlayable}");
            Console.WriteLine();

            double adventurerLevelAsDouble = adventurerLevel;
            Console.WriteLine($"Level as double (implicit): {adventurerLevelAsDouble}");

            int staminaTruncated = (int)staminaPrecise;
            int staminaRounded = Convert.ToInt32(staminaPrecise);
            Console.WriteLine($"Stamina cast (truncates)  : {staminaTruncated}");
            Console.WriteLine($"Stamina Convert (rounds)  : {staminaRounded}");
        }
    }
}
