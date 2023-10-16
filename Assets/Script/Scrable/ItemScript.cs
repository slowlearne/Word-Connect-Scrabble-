/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class ItemScript : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler,IPointerUpHandler*//*IPointerDownHandler*//*
{
    public string letter_Storer;
    public LevelManager levelObj;
    public GameManager GameManagerObj;
    public LineManager lineManagerObj;
    public GameObject LineManagerStorer;

    

    public void OnPointerEnter(PointerEventData eventData)
    {
        print("item name is: "+gameObject.name);
        letter_Storer = gameObject.transform.GetChild(0).GetComponent<TMP_Text>().text;
        levelObj.Add_letter_ToList(letter_Storer);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        print("exited");
    }

    
    public void OnPointerUp(PointerEventData eventData)
    {
        print("position count yeti xa" + lineManagerObj.lr.positionCount);
        lineManagerObj.lr.positionCount = 0;
        lineManagerObj.PointsList.Clear();
        print("hi"+gameObject.name);
        if(!(levelObj.List_for_letter.Count == levelObj.charList.Count && levelObj.concatenatedString.Equals(GameManagerObj.WordToSplit)))
        {
            levelObj.List_for_letter.Clear();
            levelObj.concatenatedString = "";
        }

       

    }
   *//* bool letGrabInputPosition;
    public void OnPointerDown(PointerEventData eventData)
    {
        letGrabInputPosition = true;
        lineManagerObj.lr.positionCount = 2;
        lineManagerObj.lr.SetPosition(0, transform.position);
        LineManagerStorer.SetActive(true);
    }
    void Update()
    {
        if (letGrabInputPosition)
        {
            lineManagerObj.lr.SetPosition(lineManagerObj.lr.positionCount-1,Camera.main.ScreenToWorldPoint(Input.mousePosition));
        }
    }*//*

}
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
using System.ComponentModel;

public class ItemScript : MonoBehaviour, IPointerEnterHandler, IPointerUpHandler, IPointerDownHandler
{
    public string letter_Storer;
    public LevelManager levelObj;
    public GameManager GameManagerObj;
    public GameObject lineManagerGameObject;
    public LineManager lineManagerObj;
    Vector3 minimumDistance;


    public void OnPointerDown(PointerEventData eventData)
    {

        lineManagerObj.lineCreator.enabled = false;
        lineManagerGameObject.transform.position = transform.position;
        lineManagerObj.lineCreator.positionCount = 3;
        lineManagerObj.lineCreator.SetPosition(0, lineManagerGameObject.transform.position);
        lineManagerObj.lineCreator.SetPosition(lineManagerObj.lineCreator.positionCount - 2, transform.position);

        lineManagerGameObject.SetActive(true);
        print("line manager gameobject is acive");


        if (!lineManagerObj.linesList.Contains(gameObject))
        {
            lineManagerObj.linesList.Add(gameObject);
        }
        letter_Storer = gameObject.transform.GetChild(0).GetComponent<TMP_Text>().text;
        levelObj.Add_letter_ToList(letter_Storer);

        StartCoroutine(EnableLineRenderer());



    }
    private IEnumerator EnableLineRenderer()
    {
        // Wait for a short duration 
        yield return new WaitForSeconds(0.1f);

        // Enable the LineRenderer after the delay
        lineManagerObj.lineCreator.enabled = true;
    }


    public void OnPointerEnter(PointerEventData eventData)
    {
        //onPointer enter adding the items to line renderer
        if (lineManagerGameObject.activeSelf)
        {
            print("item name is: " + gameObject.name);


            if (!lineManagerObj.linesList.Contains(gameObject))
            {
                lineManagerObj.linesList.Add(gameObject);                       //Adding ImageItems to linesList on PointerEnter
                print("Image is added to linesList");
                lineManagerObj.lineCreator.positionCount++;
                lineManagerObj.lineCreator.SetPosition(lineManagerObj.lineCreator.positionCount - 2, gameObject.transform.position);
                letter_Storer = gameObject.transform.GetChild(0).GetComponent<TMP_Text>().text;      // adding Image_letter to List_for_letter onPointerEnter
                levelObj.Add_letter_ToList(letter_Storer);

            }

        }

    }

    public void OnPointerUp(PointerEventData eventData)
    {

        lineManagerGameObject.SetActive(false);
        lineManagerObj.lineCreator.positionCount = 0;
        lineManagerObj.linesList.Clear();

        // Emptying List_for_letter OnPointerUP if below conditions are not met.
        if (!(levelObj.List_for_letter.Count == levelObj.ArrayOfCharacter.Length && levelObj.concatenatedString.Equals(GameManagerObj.WordToSplit)))
        {
            levelObj.List_for_letter.Clear();
            levelObj.concatenatedString = "";
        }



    }



}