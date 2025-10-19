using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class MinerBehaviour : MonoBehaviour
{
    private float _time;
    private Vector3 position;
    [SerializeField]private GameObject _mine;
    
    
    // Start is called before the first frame update
    private void OnEnable()
    {
        _time = 0;
    }

    private void Update()
    {
        _time += Time.deltaTime;
        
        
        
        //Mining
        if (_time >= 5f)
        {
            _time = 0;
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            var pos = player.transform.position;
            position = new Vector3(pos.x, pos.y, pos.z / 2);
            Instantiate(_mine, position, transform.rotation);
        }
    }
}
