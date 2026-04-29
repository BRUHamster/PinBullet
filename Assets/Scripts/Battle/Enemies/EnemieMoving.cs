using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System.Numerics;
using UnityEngine.UIElements;
using System.Linq.Expressions;
using Vector3 = UnityEngine.Vector3;
using System.IO;

public class EnemieMoving : MonoBehaviour
{

    public GameObject[] points;
    private Vector3[] _path;

    private int _counter = 0;
    private int _point;
    [SerializeField]private bool _isMoving = false;
    private Rigidbody2D _rb2D;
    [SerializeField]private Vector3 target;
    public Tweener moving;
    //void Start() => Debug.Log($"length {points.Length}");

    void OnEnable()
    {

        _rb2D = GetComponent<Rigidbody2D>();

        _path = new Vector3[points.Length];
        for (int i = 0; i < points.Length; i++)
        {
            _path[i] = points[i].transform.position;
        }

        //if (points.Length != 0) 
            //transform.position = points[0].transform.position;

        
    }


    void Update()
    {
        if (points.Length == 0) return;

        if (!_isMoving)
        {
            
            _isMoving = true;
            //moving = transform.DOMove(points[_counter].transform.position, 5f)
                //.OnComplete(() =>
                //{
                    //Debug.Log($"Point {_point} got");
                    //_isMoving = false;
                //});
            moving = transform.DOPath (
                _path,
                15f,
                PathType.CatmullRom,
                PathMode.Full3D).SetLoops(-1, LoopType.Yoyo).OnComplete(() =>
                {
                    Debug.Log($"Point {_point} got");
                    //_isMoving = false;
                });
            

            
            _point = _counter;
            _counter++;
            if (_counter > points.Length-1) _counter = 0;
            Debug.Log($"go to Point {_point-1} Counter {_counter}");
        }

    }

    
    
    
}
