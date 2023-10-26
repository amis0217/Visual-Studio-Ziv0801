using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class Monster : MonoBehaviour
    {
        int _attack = 10;
        [SerializeField] Player  _player;

        private void Start()
        {
            //_player.TakeDamage(_attack);

            for (int i = 0; i < 10; i++)
            {
                _player.TakeDamage(_attack);
                Debug.Log(_player.Health);
            }

            //Debug.Log(_player.Health);
        }
    }
}