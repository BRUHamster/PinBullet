using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDestroing : MonoBehaviour
{
    [SerializeField]private GameObject _destroyEffect;

    void OnDestroy()
    {
        Instantiate(_destroyEffect, transform.position, transform.rotation);
    }
    
}
