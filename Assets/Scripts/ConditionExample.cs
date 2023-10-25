using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class ConditionExample : MonoBehaviour
    {
        int health = 100;

        private void Start()
        {
            if (health >= 0)
            {
                Debug.Log("我還活著");
                 
            }
        }

    }
}             //&&  和(缺一不可的意思)    //||  或者(任一條件滿足時)            //&&順序比||優先