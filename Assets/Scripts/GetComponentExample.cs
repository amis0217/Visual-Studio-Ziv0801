using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class GetComponentExample : MonoBehaviour
    {
        [SerializeField] SpawnManager spawnManager;

        private void Start()
        {
            GameObject cube = spawnManager.Spawn();
            //MeshRenderer cubeMeshRender = cube.GetComponent<MeshRenderer>();
            //if (cubeMeshRender != null)
            //{
            //    cubeMeshRender.enabled = false;
            //}

            if (cube.TryGetComponent(out MeshRenderer cubeMeshRender))
            {
                cubeMeshRender.enabled = false;
            }
            
        }
    }
}