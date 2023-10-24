using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] GoddessBlessing goddessBlessing;

    int _health = 120;

    public void TakeDamage(int amount)
    {
        amount = goddessBlessing.ReduceDamage(amount);

        _health -= amount;
        Debug.Log(_health);

        
    } 
}
