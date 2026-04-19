using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class EnemyBehaviour : MonoBehaviour
{
    //basic values

    public bool isFrozen = false;
    public float freezeDuration = 3f;
    
    protected Transform _transform1;
    
   

    void OnEnable()
    {
        CommonAct();
        UnCommanAct();
    }

    void CommonAct()
    {
    }
    
    

    void OnTriggerEnter2D(Collider2D collision) //every enemy is stunning
    {
        
        if (collision.gameObject.GetComponent<Dash>() != null && collision.gameObject.GetComponent<Dash>().IsDashing())
            StartCoroutine(Stun(duration: freezeDuration));
            
    }
    protected IEnumerator Stun(float duration) //stun animation
    {
        isFrozen = true;
        
        transform.GetComponent<SpriteRenderer>().color = Color.gray;
        yield return new WaitForSeconds(duration);
        isFrozen = false;
        transform.GetComponent<SpriteRenderer>().color = Color.white;
    }


    protected  void UnCommanAct() //void for children
    {
        Debug.Log("Enemy");
    }
}
