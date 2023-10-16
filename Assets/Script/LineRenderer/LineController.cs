using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LineController : MonoBehaviour
{
    
    public LineRenderer lr;
    Vector3 previousPoistion;
    public List<Vector3> PointsList = new List<Vector3>();
    Vector3 currentPosition;
    // Start is called before the first frame update
    
    void Start()
    {
        lr = GetComponent<LineRenderer>();
        lr.positionCount = 1;
        print(lr.transform.position);
     
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            currentPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            currentPosition.z = 0f;
            lr.SetPosition(lr.positionCount-1, currentPosition);
        }
    }

}
