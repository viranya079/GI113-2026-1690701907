 /*
 * Student ID : 1690701907
 * Name       : Viranya Pheathong
 * Section    : 129C
 * No.        : 3
 * Course     : GI113 Computer Programming (GI)
 */
using System;

namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // กำหนดค่าเริ่มต้นของตัวละคร
            int ditalinerHp = 500;
            int ditalinerSanity = 100;
            int eighaHp = 400;
            int atk = 100;
            int healAmount = 80;
            int sanityCost = 30;

            // แสดงหน้าจอเมนูเกม
            Console.WriteLine("==>> DITALINER vs. EIGHA <<==");
            Console.WriteLine("ACTION 1: ATTACK EIGHA");
            Console.WriteLine("ACTION 2: USE HEAL SKILL (Cost 30 Sanity, Restore 80 HP)");
            Console.WriteLine("ACTION 3: REST (Restore 40 Sanity)");
            Console.Write("Choose your action (1-3): ");

            // ใช้ TryParse เพื่อป้องกันโปรแกรมพังเมื่อพิมพ์ตัวอักษรหรือกด Enter เปล่า
            bool isValidInput = int.TryParse(Console.ReadLine(), out int choice);

            // ตรวจสอบความถูกต้องของ Input และแยก Branch ด้วย if / else if / else
            if (!isValidInput || choice < 1 || choice > 3)
            {
                Console.WriteLine("Invalid input. Please choose a number between 1 and 3.");
            }
            else if (choice == 1) // กิ่งที่ 1: โจมตี Eigha
            {
                eighaHp -= atk;
                if (eighaHp <= 0)
                {
                    Console.WriteLine("Ditaliner attacked Eigha! Eigha is defeated. Ditaliner wins!");
                }
                else
                {
                    Console.WriteLine("Ditaliner attacked Eigha for " + atk + " damage. Eigha HP is now " + eighaHp + ".");
                }
            }
            else if (choice == 2) // กิ่งที่ 2: ใช้สกิลฮิล (ต้องเช็คค่าสติพอก่อน)
            {
                if (ditalinerSanity >= sanityCost)
                {
                    ditalinerHp += healAmount;
                    ditalinerSanity -= sanityCost;
                    Console.WriteLine("Ditaliner used Heal Skill! Ditaliner HP is now " + ditalinerHp + ", Sanity is now " + ditalinerSanity + ".");
                }
                else
                {
                    Console.WriteLine("Not enough Sanity to use Heal Skill! Current Sanity is " + ditalinerSanity + ".");
                }
            }
            else if (choice == 3) // กิ่งที่ 3: พักผ่อนเพื่อฟื้นฟูค่าสติ
            {
                ditalinerSanity += 40;
                Console.WriteLine("Ditaliner rested and recovered Sanity. Current Sanity is " + ditalinerSanity + ".");
            }
        }
    }
}
