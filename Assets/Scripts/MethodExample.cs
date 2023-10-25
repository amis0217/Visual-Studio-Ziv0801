using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class MethodExample : MonoBehaviour
    {
        int health = 100;

        private void Start()
        {
            health ++;
            HealthMinusTwo();
            Debug.Log(health);
        }

        void HealthMinusTwo()
        {
            health -= 2;
        }


    }
}