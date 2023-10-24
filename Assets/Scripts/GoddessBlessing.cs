using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoddessBlessing : MonoBehaviour
{


    public int ReduceDamage(int damage)
    {
        damage -= 5;
        return damage;
    }
}
