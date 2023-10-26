using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class Player : MonoBehaviour
    {
        int _health = 100;
        [SerializeField] GoddessBlessing _blessing;

        public int Health { get { return _health; } }
        // public int MaxHandCardsLimit { get; } = 7;

        /// <summary>
        /// 讓玩家受傷害
        /// </summary>
        /// <param name="amount">數量</param>
        public void TakeDamage(int amount)
        {
            amount = _blessing.ReduceDamage(amount);

            if (amount >0)
            {
                int healthRemain = _health -= amount;

                if (healthRemain < 0)
                {
                    _health = 0;
                }
                else
                {
                    _health = healthRemain;
                }
            }
            

            //Debug.Log(_health);
        }
    }
}