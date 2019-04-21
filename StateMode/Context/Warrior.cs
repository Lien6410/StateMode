using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StateMode.State;

namespace StateMode.Context
{
    /// <summary>
    /// 鬥士(Context)
    /// </summary>
    public class Warrior
    {
        private int hp; // 生命值(0~100)
        private IState state; // 目前狀態

        public Warrior()
        {
            //一開始為滿HP狀態
            hp = 100;
            state = new NormalState();
        }

        /// <summary>
        /// 治療 - 恢復HP
        /// </summary>
        /// <param name="heal"></param>
        public void Heal(int heal)
        {
            hp += heal;

            //移除過量治療
            if (hp > 100)
            {
                hp = 100;
            }
        }

        /// <summary>
        /// 受傷 - 減少HP
        /// </summary>
        /// <param name="damage"></param>
        public void GetDamage(int damage)
        {
            hp -= damage;

            //移除過量擊殺
            if (hp < 0)
            {
                hp = 0;
            }
        }

        /// <summary>
        /// 講實際的執行交給State處理
        /// </summary>
        public void Move()
        {
            state.Move(this);
        }

        public int GetHp()
        {
            return hp;
        }

        public void SetState(IState state)
        {
            this.state = state;
        }


    }
}
