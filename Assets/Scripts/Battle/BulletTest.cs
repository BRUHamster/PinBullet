using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTest : MonoBehaviour
{
    private float _time = 0.0f;
    [SerializeField] private GameObject _bullet;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _time += Time.deltaTime;

        if (_time >= 1.0f)
        {
            _time = 0;
            Instantiate(_bullet, new Vector2(0,2), transform.rotation);
        }
    }
}
