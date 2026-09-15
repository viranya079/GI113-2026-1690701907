/*
* Student ID : 1690701907
* Name       :viranya phaethong
* Section    :129c
* No.        :
* Course     : GI113 Computer Programming (GI)
*/

namespace LAB05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Game title, Sub-title
            Console.WriteLine("==>> MY GAME DEE <<==");
            Console.WriteLine("Hero vs. Monster, Fight damage calulator\n");

            //Hero stats input
            Console.Write("Hero Health: ");
            bool heroHpOk = int.TryParse(Console.ReadLine(), out int heroHp);
            Console.Write("Hero Attack: ");
            bool heroAtkOk = int.TryParse(Console.ReadLine(), out int heroAtk);
            Console.Write("Hero Defense: ");
            bool heroDefOk = int.TryParse(Console.ReadLine(), out int heroDef);

            //Monster stats input
            Console.Write("Monster Health: ");
            bool monsterHpOk = int.TryParse(Console.ReadLine(), out int monsterHp);
            Console.Write("Monster Attack: ");
            bool monsterAtkOk = int.TryParse(Console.ReadLine(), out int monsterAtk);
            Console.Write("Monster Defense: ");
            bool monsterDefOk = int.TryParse(Console.ReadLine(), out int monsterDef);
            //Input validation
            bool isHeroIntValid = heroHpOk && heroAtkOk && heroDefOk;
            bool isMonsterIntValid = monsterHpOk && monsterAtkOk && monsterDefOk;
            Console.WriteLine($"\nHERO STATUS VALID: {isHeroIntValid}");
            Console.WriteLine($"MONSTER STATUS VALID: {isMonsterIntValid}");

            Console.WriteLine($"\n[HERO] HP: {heroHp}, ATK: {heroAtk}, DEF: {heroDef}");
            Console.WriteLine($"[MONSTER] HP: {monsterHp}, ATK: {monsterAtk}, DEF: {monsterDef}");
            //bool allIntValid = !osHeroInValid && isMonInValid;
            // ถ้าเอาแค่ชื่อ boolม่เช็ค คือ เช็คว่าเป็นจริงมั้น? ! ด้ายหน้าคือตรงข้าม (จริง->เท็จ)

            //Compound assignment : += จำลองสถาณการณ์ผู้เล่นดื่ม Potion ก่อนต่อสู้
            int potionHeal = 8;
            //heroHp = heroHp + potionHeal; //แบบยาว
            heroHp += potionHeal; //แบบสั้น ความหมายเดียวกัน นำ potionHeal มา + กับ heroHp กับ heroHp
            Console.WriteLine ($"\nHero drinks a potion and healing {potionHeal} HP. New Hero HP: {heroHp}");
            //Arithmetic +
            int normDmg = heroAtk - monsterDef; // ความแรงการโจมตีขึ้นอยู่กับค่าป้องกันของศัตรู
            Console.WriteLine("$\nNormal Attack would deal {normDmg} DMG");
            //Precedence
            int pwrDmg = Math.Max(0.(heroAtk * 2) - monsterDef); //โจมตีคูณ 2 จะใส่วงเล็กหรือไม่ก็ได้เพราะทำคุณก่อน
            //Random, Simple percent chance.
            Console.WriteLine($"Power Attack would deal {pwrDmg} DMG");
            // Random, Simple percent critical chance.
            Random randomSomething = new Random();
            int roll = randomSomething.Next(1, 101); // ต้อง +1 ค่ามากสุดเสมอ เช่นอยากได้ 100 ต้อง 101
            bool isCrit = roll <= 10; // 10% chance จาก 100
            int critDmg = normDmg + Convert.ToInt32(isCrit) * normDmg; // Bool 1 หรือ 0
            Console.WriteLine($"\nCritical hit roll:{roll} (critical: {isCrit})");
            Console.WriteLine($"If critical, normal attck would instead deal: {critDmg} DMG");
        }
    }
}
