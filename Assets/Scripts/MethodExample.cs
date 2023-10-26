using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class MethodExample : MonoBehaviour
    {
        int _health = 100;

        private void Start()
        {
            _health ++;
            HealthMinusTwo();
            Debug.Log(_health);
        }

        void HealthMinusTwo()
        {
            _health -= 2;
        }


    }
}