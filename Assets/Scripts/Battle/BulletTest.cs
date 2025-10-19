using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTest : MonoBehaviour
{
    private float _time = 0.0f;
    [SerializeField] private GameObject _targetBullet;
    [SerializeField] private GameObject _frontBull;
    

    // Update is called once per frame
    void Update()
    {
        _time += Time.deltaTime;

        if (_time >= 1.0f)
        {
            _time = 0;
            //Instantiate(_targetBullet, new Vector3(0,2,-1), transform.rotation);
            var rotation = transform.rotation;
            Instantiate(_frontBull, new Vector3(-6, 3, -1), rotation);
            Instantiate(_frontBull, new Vector3(6, 3, -1), rotation);
        }
    }
}
