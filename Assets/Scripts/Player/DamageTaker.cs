using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DamageTaker : MonoBehaviour
{

    private int health;
    
    public event Action DamageTaken;
    public event Action Death;
    
    private Vector3 _scale;
    
    [SerializeField] public float scaleF = 1.5f;
    [SerializeField] public float time = 0.2f;

    

    void OnEnable()
    {
        _scale = transform.localScale;
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("Bullet") && !transform.GetComponent<Dash>().IsDashing())
        {
            StartCoroutine(DamageAnimation());
            
            DamageTaken?.Invoke();
            health--;
            if (health <= 0)
                Death?.Invoke();
        }
    }

    
    private IEnumerator DamageAnimation()
    {
        GetComponent<SpriteRenderer>().color = Color.red;
        transform.DOScale(_scale* scaleF, time);
        yield return new WaitForSeconds(time);
        transform.DOScale(_scale, time);
        
        GetComponent<SpriteRenderer>().color = Color.white;
        
    }
}
