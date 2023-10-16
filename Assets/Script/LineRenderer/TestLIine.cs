/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TestLIine : MonoBehaviour,IPointerEnterHandler
{
    [SerializeField]
    private LineController lineControlObj;
  

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (!lineControlObj.PointsList.Contains(gameObject.transform.position))
        {
            lineControlObj.PointsList.Add(gameObject.transform.position);
            lineControlObj.lr.positionCount++;
            print("position count " + lineControlObj.lr.positionCount);
            lineControlObj.lr.SetPosition(lineControlObj.lr.positionCount-2, gameObject.transform.position);
        }
        
        
    }

   
}
*/