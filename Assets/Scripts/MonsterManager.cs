using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class MonsterManager : MonoBehaviour
    {
        [SerializeField] GameObject[] slimes;

        private void Start()
        {
            for (int i = 0; i < slimes.Length; i++)
            {
                Debug.Log(slimes[i].name);
            }
            
        }
    }
}