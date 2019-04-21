using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StateMode.Context;

namespace StateMode.State
{
    /// <summary>
    /// 隨著HP變化的狀態(State)
    /// </summary>
    public interface IState
    {
        /// <summary>
        /// 狀態不同，行為模式不同。(傳入warrior所以狀態可以取得warrior的資料)
        /// </summary>
        /// <param name="warrior"></param>
        void Move(Warrior warrior);
    }
}
