using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Unity.VisualScripting;
using UnityEngine;

public class ShooterBehavior : EnemyBehaviour
{
    
    
    private float _time;
    
    [SerializeField] public Vector2 directionofFrontBullet;

    [SerializeField] private GameObject bullet;


    private float _scale1;
    private float _scale2;
    
    void OnEnable()
    {
        _scale1 = transform.localScale.x;
        _scale2 = _scale1 * 0.8f;
    }

    
    void Update()
    {
        if (isFrozen) return; 
        
        _time += Time.deltaTime;
        
        //shooting
        if (_time >= 1f && !isFrozen)
        {

            StartCoroutine(ShootAnimation());
            _time = 0f;

        }
    }

    

    IEnumerator ShootAnimation()
    {
        transform.DOScale(_scale2, 0.7f);
        yield return new WaitForSeconds(0.7f);
        transform.DOScale(_scale1, 0.3f);
        
        GameObject spawnedBullet = Instantiate(bullet, transform.position, transform.rotation); //Bullet spawned
        

            if (spawnedBullet.TryGetComponent(out FrontBulletBehaviour frontBullet))
            {
                
                frontBullet.Init(directionofFrontBullet);
            }

            spawnedBullet.GetComponent<Bullet>().SetOwner(1);

        
    }
    

    
}
