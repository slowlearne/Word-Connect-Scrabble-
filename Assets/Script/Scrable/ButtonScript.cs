/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonScript : MonoBehaviour
{
    public GameManager gameManagerObj;
    public LevelManager levelManagerObj;
    int newValue;
    Transform singleImageStore;
    
    public List<Transform> OnButtonClick_new_List = new List<Transform>();
    private void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(OnButtonClick);
    }
    public void OnButtonClick()
    {
        print("Button Clicked");
        for(int i = 0; i < levelManagerObj.ChildPointsList.Count; i++)
        {
            OnButtonClick_new_List.Add(levelManagerObj.ChildPointsList[i]);
        }
        

        for (int i = 0; i <levelManagerObj.instantiatedObjects.Count;i++)
        {
            newValue = Random.Range(0, OnButtonClick_new_List.Count);
            print("the new value is: " + newValue);
            print("instance object position is " + levelManagerObj.instantiatedObjects[i].transform.position);
       
            levelManagerObj.instantiatedObjects[i].transform.position = OnButtonClick_new_List[newValue].transform.position;
            OnButtonClick_new_List.RemoveAt(newValue);
            print("child lisyt ko count "+OnButtonClick_new_List.Count);

            
        }

    }
}
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Experimental.AI;

public class ButtonScript : MonoBehaviour
{
    public GameManager gameManagerObj;
    public LevelManager levelManagerObj;
    int newValue;
    public GameObject GameObjectForCenterPoint;


    public List<Transform> OnButtonClick_new_List = new List<Transform>();
    private void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(OnButtonClick);
    }
    public void OnButtonClick()
    {
        GetComponent<Button>().interactable = false;

        for (int i = 0; i < levelManagerObj.ChildPointsList.Count; i++)
        {
            OnButtonClick_new_List.Add(levelManagerObj.ChildPointsList[i]);
        }
        //moving to left side first 
        for (int i = 0; i < levelManagerObj.instantiatedObjects.Count; i++)
        {
            /*newValue = Random.Range(0, OnButtonClick_new_List.Count);*/
            /*levelManagerObj.instantiatedObjects[i].SetActive(false);
            levelManagerObj.instantiatedObjects[i].transform.position = OnButtonClick_new_List[newValue].transform.position;
            levelManagerObj.instantiatedObjects[i].SetActive(true);*/
            if (i == levelManagerObj.instantiatedObjects.Count - 1)
            {
                LeanTween.move(levelManagerObj.instantiatedObjects[i], levelManagerObj.ChildPointsList[0].transform.position, 0.5f).setOnComplete(moveItemsToCenter);


            }
            else
            {
                LeanTween.move(levelManagerObj.instantiatedObjects[i], levelManagerObj.ChildPointsList[i + 1].transform.position, 0.5f).setOnComplete(() => { });


            }



        }


    }
    Coroutine moveItemToNewPlace;
    public void moveItemsToCenter()
    {
        print("count of instantiate object" + levelManagerObj.instantiatedObjects.Count);
        for (int i = 0; i < levelManagerObj.instantiatedObjects.Count; i++)
        {
            print("move item to center " + i);
            /*LeanTween.move(levelManagerObj.instantiatedObjects[i], GameObjectForCenterPoint.transform.position, 0.5f);*/

            LeanTween.move(levelManagerObj.instantiatedObjects[i], GameObjectForCenterPoint.transform.position, 0.5f).setOnComplete(() =>
            {
                print(levelManagerObj.instantiatedObjects.Count - 1);
                print("i value" + i);
                if (i == levelManagerObj.instantiatedObjects.Count)
                {
                    if (moveItemToNewPlace == null)
                        moveItemToNewPlace = StartCoroutine(MoveItemToNewPlace());

                }
            });
        }

    }

    public IEnumerator MoveItemToNewPlace()
    {
        yield return new WaitForSeconds(0.2f);
        for (int i = 0; i < levelManagerObj.instantiatedObjects.Count; i++)
        {

            /* print("button list ko count" + OnButtonClick_new_List.Count);*/
            newValue = Random.Range(0, OnButtonClick_new_List.Count);

            /*levelManagerObj.instantiatedObjects[i].transform.position = OnButtonClick_new_List[newValue].transform.position;*/

            LeanTween.move(levelManagerObj.instantiatedObjects[i], OnButtonClick_new_List[newValue].transform.position, 0.1f);

            OnButtonClick_new_List.Remove(OnButtonClick_new_List[newValue]);



        }
        yield return new WaitForSeconds(0.2f);
        moveItemToNewPlace = null;
        GetComponent<Button>().interactable = true;
    }





}