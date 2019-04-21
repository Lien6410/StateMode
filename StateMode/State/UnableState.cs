using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StateMode.Context;

namespace StateMode.State
{
    /// <summary>
    /// 隨著HP變化的狀態(ConcreteState)，HP = 0% 無法戰鬥狀態
    /// </summary>
    public class UnableState : IState
    {
        /// <summary>
        ///  狀態不同，行為模式不同。(傳入warrior所以狀態可以取得warrior的資料)
        /// </summary>
        /// <param name="warrior"></param>
        public void Move(Warrior warrior)
        {
            Console.WriteLine("HP = " + warrior.GetHp() + " ，無法戰鬥。");
        }
    }
}
