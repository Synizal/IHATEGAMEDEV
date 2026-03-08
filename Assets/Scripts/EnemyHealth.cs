using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : Health
{
    protected override void Die()
    {
        base.Die(); // Gọi hàm Die() của lớp Health
        Debug.Log("Enemy died");
    }
}