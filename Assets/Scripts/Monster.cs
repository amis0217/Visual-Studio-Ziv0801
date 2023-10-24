using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    [SerializeField] Player player;

    int _attack = 8;
    

   

    
    private void Start()
    {
        //Debug.Log(player._health);
        player.TakeDamage(_attack);
    }
}
