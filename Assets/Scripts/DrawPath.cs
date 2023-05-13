using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawPath : MonoBehaviour
{
    [SerializeField] private LineRenderer _line;
    public Vector3[] path;
    public bool isDrawOver { get; private set; } = false;
    
    void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out var info))
        {
            Vector3 pos = info.point;
            pos.z = 0;
            if (Input.GetMouseButton(0))
            {
                isDrawOver = false;
                _line.positionCount++;
                _line.SetPosition(_line.positionCount - 1, pos);
            }
            else
            {
                if (_line.positionCount > 1)
                {
                    isDrawOver = true;
                }
                path = new Vector3[_line.positionCount];
                for (int i = 0; i < path.Length; i++)
                {
                    path[i] = _line.GetPosition(i);
                }
            }
        }
    }
}
