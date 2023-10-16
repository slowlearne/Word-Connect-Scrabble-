using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class CreateLineByAddingPoints : MonoBehaviour/*IPointerEnterHandler*//*,IPointerUpHandler
*/{
    [SerializeField]
    private LineManager lineManagerObj;


   /* public void OnPointerEnter(PointerEventData eventData)
    {
        if (!lineManagerObj.PointsList.Contains(gameObject.transform.position))
        {
            lineManagerObj.PointsList.Add(gameObject.transform.position);
            lineManagerObj.lr.positionCount++;
            print("position count " + lineManagerObj.lr.positionCount);
            lineManagerObj.lr.SetPosition(lineManagerObj.lr.positionCount - 2, gameObject.transform.position);
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        lineManagerObj.lr.positionCount = 0;
        lineManagerObj.lr.enabled = false;
    }*/
}
