using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class Mono : MonoBehaviour
    {
        private POCO _poco = new POCO();

        private void Start()
        {
            _poco.Talk();
        }
    }
}