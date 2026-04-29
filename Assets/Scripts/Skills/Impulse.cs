using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Impulse : MonoBehaviour
{
    // Start is called before the first frame update
    
    private Vector3 trueScale;

    void OnEnable()
    {
        trueScale = transform.localScale;
        transform.DOScale(trueScale * 10f, 2f).OnComplete(() =>
            {
                SpriteRenderer sprite = GetComponent<SpriteRenderer>();

                sprite.DOFade(0, 0.5f).OnComplete(() => //fading out
                {
                    transform.localScale = trueScale; //Scaling down
                    Destroy(gameObject);
                });

            });
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.LogError("Collided with " + other.name);
    }




}
