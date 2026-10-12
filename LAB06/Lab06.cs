/*
 * Student ID : 1690701907
 * Name       : 06
 * Section    : 129C
 * No.        : 3
 * Course     : GI113 Computer Programming (GI)
 */
namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int lives = 1;

            //if (lives == 0) // ใส่เงื่อนไขที่ต้องการเช็ค ค่าที่ได้ต้องเป็น bool true / false
            //{
            // Codeด้านในจะรันก็ต่อเมื่อ if เป็น true เท่านั้น
            //Console.WriteLine("Game Over");
            //}
            //else
            //{
            // Console.WriteLine("Keep Fighting");
            //}

            // ถ้า if ทำงานเสร็จแล้ว หรือเป็น false จะทำงานต่อมาบรรทัดด้านนอกทันที
            // Console.WriteLine("Continue Code");

            // int level = 10;
            //bool hasKey = true;

            //Console.WriteLine("Your Level (1-99): ");
            //bool inputValid = int.TryParse(Console.ReadLine(), out int level);

            //if (inputValid || level < 99) // เงื่อนไขที่ถือว่าข้อมูลผิด
            //{
            //Console.WriteLine("Invalid Level"); // เตือนเมื่อ user ใส่ข้อมูลผิด
            //}    

            // เมื่อใช้เงื่อนไขหลายเคส ให้เช็คเลขจาก มาก -> น้อย เสมอ
            //else if (level >= 10 && hasKey) // เงื่อนไข 1 หรือเท่ากับ 10 และต้องมีกุญแจ
            //{
            //Console.WriteLine("The door open.");
            //}
            //else if (level >= 5) // เงื่อนไข 2 ถ้ายังไม่ตรงเงื่อนไข 1
            //{
            //Console.WriteLine("Boss floor unloked");
            //}
            //else // เมื่อไม่ตรงสักเงื่อนไข
            //{
            //Console.WriteLine("The door stay shut.");
            //}

            //bool isPosioned = true;

            //if (isPosioned == true) // เช็คว่าเป็นจริงไหม
            //{
            //Console.WriteLine("You Died");
            //}
            //else if (isPosioned != true) // เช็คว่าเป็นเท็จไหม  
            //{
            //Console.WriteLine("You Lives");
            //}


            // กำหนดค่าเริ่มต้นของตัวละคร
            int ditalinerHp = 500;   // พลังชีวิต/สตามินาของ Ditaliner
            int ditalinerSanity = 100; // ค่าสติของ Ditaliner
            
            int eighaHp = 400;       // พลังชีวิตของ Eigha
            int atk = 100;           // ดาเมจปกติ
            int skillHeal = 80;      // ฟื้นฟู HP เมื่อใช้สกิลฮีล
            int sanityCost = 20;     // ค่าสติที่ใช้เมื่อใช้สกิลฮีล

            Console.WriteLine("==>> DITALINER vs. EIGHA <<==");
            Console.WriteLine("Choose your action:");
            Console.WriteLine("ACTION 1: ATTACK EIGHA");
            Console.WriteLine("ACTION 2: HEAL SKILL (Restore HP, consume Sanity)");
            Console.WriteLine("ACTION 3: REST (Restore Sanity)");

            Console.Write("Choose your action (1-3): ");
            bool userInput = int.TryParse(Console.ReadLine(), out int choice);

            // ตรวจสอบความถูกต้องของ Input (รองรับตัวเลือก 1 ถึง 3)
            if (!userInput || choice < 1 || choice > 3)
            {
                Console.WriteLine("Invalid input, please choose a number between 1-3 only.");
            }
            else if (choice == 1) // โจมตี Eigha
            {
                eighaHp -= atk;
                if (eighaHp <= 0)
                {
                    Console.WriteLine("Eigha is Defeated! Ditaliner wins!");
                }
                else
                {
                    Console.WriteLine("Ditaliner attacked Eigha! Eigha has " + eighaHp + " HP left.");
                }
            }
            else if (choice == 2) // ใช้สกิลฮีล (เสียค่าสติ เพิ่ม HP)
            {
                if (ditalinerSanity >= sanityCost)
                {
                    ditalinerHp += skillHeal;
                    ditalinerSanity -= sanityCost;
                    Console.WriteLine("Ditaliner used Heal Skill!");
                    Console.WriteLine("Ditaliner HP: " + ditalinerHp + " | Sanity Left: " + ditalinerSanity);
                }
                else
                {
                    Console.WriteLine("Not enough Sanity to use Heal Skill!");
                }
            }
            else if (choice == 3) // พักผ่อนเพื่อฟื้นฟูค่าสติ
            {
                ditalinerSanity += 30;
                Console.WriteLine("Ditaliner rested to recover Sanity. Current Sanity: " + ditalinerSanity);
            }
        }
    }
}
