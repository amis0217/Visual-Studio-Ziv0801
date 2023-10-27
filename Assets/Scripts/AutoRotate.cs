using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class AutoRotate : MonoBehaviour
    {
        public float _speed = 10;

        private void Update()
        {
            this.transform.Rotate(0, Time.deltaTime * _speed * 10, 0);
        }

    }
}