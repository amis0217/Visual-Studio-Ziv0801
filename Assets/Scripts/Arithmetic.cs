﻿using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class Arithmetic : MonoBehaviour
    {
        int _health = 100;

        private void Start()
        {
            //health = health - 1;     以下簡寫
            _health -= 1;             
            //    health --;  //如果是減1可以再更簡化

            Debug.Log(_health);
        }
    }
}