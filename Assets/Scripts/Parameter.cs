using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class Parameter : MonoBehaviour
    {
        int _health = 100;
        public int ADD = 1;                     //宣告ADD變數

        private void Start()
        {
            AddHealth(ADD , "King");              //ADD變數當引數使用_呼叫Method時給的值稱為引數
            
            Debug.Log(_health);
        }

        void AddHealth(int amount , string words)    //amount參數_在Method(小括弧)裡的稱為<參數>
        {
            _health += amount;
        }



    }
}