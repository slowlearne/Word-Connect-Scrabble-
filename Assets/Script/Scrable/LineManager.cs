/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LineManager : MonoBehaviour
{
    public LineRenderer lr;
    public List<Vector3> PointsList = new List<Vector3>();
    Vector3 currentPosition;

    
    void Start()
    {
        lr = GetComponent<LineRenderer>();
        lr.positionCount = 1;
        print(lr.transform.position);

    }

   *//* void Update()
    {
        if (Input.GetMouseButton(0))
        {
            currentPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            currentPosition.z = 0f;
            lr.SetPosition(lr.positionCount - 1, currentPosition);
        }
    }*//*


}
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineManager : MonoBehaviour
{
    public List<GameObject> linesList;
    public LineRenderer lineCreator;
    Vector3 currentPosition;

    void Start()
    {
        lineCreator = GetComponent<LineRenderer>();

    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            currentPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            currentPosition.z = 0f;
            lineCreator.SetPosition(lineCreator.positionCount - 1, currentPosition);
        }
    }
}