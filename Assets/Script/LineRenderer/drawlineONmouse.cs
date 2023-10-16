using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawlineONmouse : MonoBehaviour
{
    [SerializeField]
   private LineRenderer lr;
    [SerializeField]
    private Vector3 previousPosition;
    Vector3 currentPosition;
    float mindistance=0.1f;

    void Start()
    {
        lr = GetComponent<LineRenderer>();
        previousPosition = transform.position;
    }

   
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            currentPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            currentPosition.z = 0f;
            if (Vector3.Distance(previousPosition, currentPosition) > mindistance)
            {
                if (previousPosition == transform.position)
                {
                    lr.SetPosition(0, currentPosition);
                }
                else
                {
                    lr.positionCount++;

                }
                lr.SetPosition(lr.positionCount - 1, currentPosition);
                previousPosition = currentPosition;
            }
        }

    }
}
