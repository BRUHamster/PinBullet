using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    //basic values

    public bool isFrozen = false; 
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator Freezing()
    {
        isFrozen = true;
        yield return new WaitForSeconds(2);
        isFrozen = false; 
    }
    
    
}
