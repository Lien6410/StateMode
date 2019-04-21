using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StateMode.Context;

namespace StateMode.State
{
    /// <summary>
    /// 隨著HP變化的狀態(ConcreteState)，HP below 30% 背水一戰狀態
    /// </summary>
    public class DesperateMode : IState
    {
        /// <summary>
        /// 狀態不同，行為模式不同。(傳入warrior所以狀態可以取得warrior的資料)
        /// </summary>
        /// <param name="warrior"></param>
        public void Move(Warrior warrior)
        {
            int hp = warrior.GetHp();

            if (hp > 30)
            {
                warrior.SetState(new FuryState());
                warrior.Move();
            }
            else if (hp == 0)
            {
                warrior.SetState(new UnableState());
                warrior.Move();
            }
            else
            {
                Console.WriteLine("HP = " + hp + " ，背水一戰狀態 傷害增加50% 防禦增加50%。");
            }
        }
    }
}
