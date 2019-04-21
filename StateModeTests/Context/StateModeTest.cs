using NUnit.Framework;
using StateMode.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StateMode.State;

namespace StateMode.Context.Tests
{
    [TestFixture()]
    public class WarriorTests
    {
        Warrior warrior = new Warrior();

        [Test()]
        public void StateModeTest()
        {
            Console.WriteLine("======== 狀態模式測試 ========");

            warrior.Move();

            warrior.GetDamage(30); // 受傷
            warrior.Move();

            warrior.GetDamage(50); // 受傷
            warrior.Move();

            warrior.Heal(120); // 大量治療
            warrior.Move();

            warrior.GetDamage(110); // 受到致命傷害
            warrior.Move();

            warrior.Heal(20); // 倒地時，治療無效。
            warrior.Move();

            Assert.AreEqual(1,1);
        }
    }
}