using System.Collections;
using UnityEngine;
using UnityEngine.AI;

namespace Assets.Scripts
{
    public class NavMeshMovement : MonoBehaviour
    {
        [SerializeField] NavMeshAgent agent;
        [SerializeField] Transform target;

        private void Start()
        {
            //if (slime.TryGetComponent(out NavMeshMovement navMeshMovement))
            //{
            //    navMeshMovement.enabled = false;
            //}
        }

        private void Update()
        {
            agent.SetDestination(target.position);
        }
    }
}