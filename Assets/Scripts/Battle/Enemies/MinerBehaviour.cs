using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class MinerBehaviour : EnemyBehaviour   
{
    private float _time;
    private Vector3 position;
    [SerializeField]private GameObject _mine;
    
    
    // Start is called before the first frame update
    void UnCommanAct() //void for children
    {
        _time = 0;
        Debug.Log("NEW MINER");
    }

    private void Update()
    {
        if (isFrozen) return;
        
        _time += Time.deltaTime;
        
        
        //Mining
        if (_time >= 5f)
        {
            _time = 0;
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            var pos = player.transform.position;
            position = new Vector3(pos.x, pos.y, 1);
            Instantiate(_mine, position, transform.rotation);
        }
    }
}
