using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : EnemyBehaviour
{



    private void OnTriggerEnter2D(Collider2D other)
    {
        

    
    }

    void Death()
    {
        Destroy(transform.gameObject);
    }
    
    

    IEnumerator Shock()
    {
        isFrozen = true;
        yield return new WaitForSeconds(5f);
        isFrozen = false;  
    }
    
}
