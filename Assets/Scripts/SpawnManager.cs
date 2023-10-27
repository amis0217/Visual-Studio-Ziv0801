using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class SpawnManager : MonoBehaviour
    {
        [SerializeField] GameObject prefab;

        public GameObject Spawn()
        {
            GameObject cube = Instantiate(prefab);
            return cube;
        }
    }
}