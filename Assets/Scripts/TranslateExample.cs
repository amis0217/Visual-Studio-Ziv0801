using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class TranslateExample : MonoBehaviour
    {
        private void Start()
        {
            transform.Translate(1, 4, 3);
        }
    }
}