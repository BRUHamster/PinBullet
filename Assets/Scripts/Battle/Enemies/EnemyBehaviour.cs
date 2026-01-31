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
    [SerializeField] protected Vector2 _point1;
    [SerializeField] protected Vector2 _point2;
    
    
    

    void Moving()
    {
        Vector2 position = _transform1.position;
        if (_point1 == _point2 == null)
            return;
        
        if (position == _point1)
            transform.DOMove(_point2, 3f); //moving mechanic i guess
        if (position == _point2)
            transform.DOMove(_point1, 3f);
    }

    void OnTriggerEnter2D(Collider2D collision) //every enemy is stunning
    {
        
        if (collision.gameObject.GetComponent<Dash>() != null)
            StartCoroutine(Stun(duration: freezeDuration));
        else
            Debug.Log(collision.name);
    }
    protected IEnumerator Stun(float duration)
    {
        isFrozen = true;
        
        transform.GetComponent<SpriteRenderer>().color = Color.gray;
        yield return new WaitForSeconds(duration);
        isFrozen = false;
        transform.GetComponent<SpriteRenderer>().color = Color.white;
    }
    
    
    
    
}
