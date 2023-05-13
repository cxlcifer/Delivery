using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Finish : MonoBehaviour
{
    [SerializeField] private Transform _finish;
    [SerializeField] private BoxController _box;
    [SerializeField] private Movement _path;

    [SerializeField] private UnityEvent _event;

    public bool isFinished = false;
    void Update()
    {
        if (transform.position.x <= _finish.position.x)
        {
            isFinished = true;
            _path.StopAllCoroutines();
            _box.DropDown(_finish.position);
            _event.Invoke();
        }
    }
}
