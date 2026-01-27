using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class EnemyBehaviour : MonoBehaviour
{
    //basic values

    public bool isFrozen = false; 
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

    void OnTriggerEnter2D(Collider2D collision) //every enemie is sunning
    {
        
        if (collision.gameObject.tag == "Player")
            StartCoroutine(Stun(duration: 5f));
    }
    protected IEnumerator Stun(float duration)
    {
        isFrozen = true;
        transform.GetComponent<SpriteRenderer>().color = Color.blue;
        for (int i = 1; i <= duration; i++)
        {
            transform.GetComponent<SpriteRenderer>().color = Color.gray;
            yield return new WaitForSeconds(1f);
            transform.GetComponent<SpriteRenderer>().color = Color.blue;
        }
        
        
        isFrozen = false;
        transform.GetComponent<SpriteRenderer>().color = Color.white;
    }
    
    
    
    
}
