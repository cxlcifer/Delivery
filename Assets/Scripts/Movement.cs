using System;
using System.Collections;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private DrawPath _path;
    [SerializeField] private float time;
    [SerializeField] private float _speed;
    
    private int index = 0;
    private bool isGo = true;
    
    private void Update()
    {
        if (_path.isDrawOver)
        {
            if (isGo)
            {
                StartCoroutine(Go());
                isGo = false;
            }
        }
    }
    
    private IEnumerator Go()
    {

        while (index < _path.path.Length)
        {
            transform.position = Vector3.MoveTowards(transform.position, _path.path[index], _speed);
            index++;
            yield return new WaitForSeconds(time);
        }
    }
    
}