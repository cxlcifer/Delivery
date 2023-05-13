using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Lose : MonoBehaviour
{
    [SerializeField] private Finish _finish;
    [SerializeField] private UnityEvent _event;
    private void OnCollisionEnter(Collision collision)
    {
        if (!_finish.isFinished)
        {
            _event.Invoke();
        }
    }
}
