using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class ConditionExample : MonoBehaviour
    {
        //int _health = 100;
        bool _canAttack = true;

        private void Start()
        {
            if (_canAttack == true)
            {
                Debug.Log("成功攻擊");
                 
            }
        }

    }
}             //&&  和(缺一不可的意思)    //||  或者(任一條件滿足時)            //&&順序比||優先