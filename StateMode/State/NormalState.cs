using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StateMode.Context;

namespace StateMode.State
{
    /// <summary>
    /// 隨著HP變化的狀態(ConcreteState)，HP above 70% 一般狀態
    /// </summary>
    public class NormalState : IState
    {
        /// <summary>
        /// 狀態不同，行為模式不同。(傳入warrior所以狀態可以取得warrior的資料)
        /// </summary>
        /// <param name="warrior">取得鬥士資訊</param>
        public void Move(Warrior warrior)
        {
            int hp = warrior.GetHp();
            if (hp > 70)
            {
                Console.WriteLine("HP = " + hp + " ，一般狀態。");
            }
            else
            {
                warrior.SetState(new FuryState());
                warrior.Move();
            }
        }
    }
}
