/*using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public LevelManager levelManagerObj;
    public GameObject PointStorer, levelManagerStore;
    public string WordToSplit;
    public int numerOfObjectToSpawn, Length_of_Word;
    GameObject ThreePointParentStore, FourPointParentStore, FivePointParentStore, SixPointParentStore, SevenPointParentStore;
    void Awake()
    {
        ThreePointParentStore = GameObject.Find("ThreePoint");
        FourPointParentStore = GameObject.Find("FourPoint");
        FivePointParentStore = GameObject.Find("FivePoint");
        SixPointParentStore = GameObject.Find("SixPoint");
        SevenPointParentStore = GameObject.Find("SevenPoint");

        ThreePointParentStore.SetActive(false);
        FourPointParentStore.SetActive(false);
        FivePointParentStore.SetActive(false);
        SixPointParentStore.SetActive(false);
        SevenPointParentStore.SetActive(false);
        levelManagerStore.SetActive(false);
        StartNewLevel();
    }
    public void StartNewLevel()
    {
        

        WordToSplit = GameObject.Find("Header").transform.GetChild(0).GetComponent<TMP_Text>().text;
        print(WordToSplit);
        Length_of_Word = WordToSplit.Length;
        print("the length of word is " + Length_of_Word);
        numerOfObjectToSpawn = Length_of_Word;

        if (Length_of_Word == 3)
        {
            PointStorer = ThreePointParentStore;
            PointStorer.SetActive(true);
            levelManagerStore.SetActive(true);

            *//*ThreePointParentStore.SetActive(true);*//*
        }
        else if (Length_of_Word == 4)
        {
            PointStorer = FourPointParentStore;
            PointStorer.SetActive(true);
            levelManagerStore.SetActive(true);
            *//*FourPointParentStore.SetActive(true);*//*
        }
        else if (Length_of_Word == 5)
        {
            PointStorer = FivePointParentStore;
            PointStorer.SetActive(true);
            levelManagerStore.SetActive(true);
            *//*FivePointParentStore.SetActive(true);*//*
        }
        else if (Length_of_Word == 6)
        {
            PointStorer = SixPointParentStore;
            PointStorer.SetActive(true);
            levelManagerStore.SetActive(true);
            *//*SixPointParentStore.SetActive(true);*//*
        }
        else
        {
            PointStorer = SevenPointParentStore;
            PointStorer.SetActive(true);
            levelManagerStore.SetActive(true);
            *//* SevenPointParentStore.SetActive(true);*//*
        }
    }

    public void GameOver()
    {
        print("word before change" + WordToSplit);
        WordToSplit = "";
        levelManagerObj.concatenatedString = "";
        print("after change" + WordToSplit);
        GameObject.Find("Header").transform.GetChild(0).GetComponent<TMP_Text>().text = "";
        GameObject.Find("Header").transform.GetChild(0).GetComponent<TMP_Text>().text = "PRABIN";


        if (WordToSplit!= null)
        {
            print("not null");
            StartNewLevel();
        }
        else
        {
            print("word is empty");
        }
        
    }
}

*/

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public LineManager lineManagerObj;
    public ItemScript ItemScriptObj;
    public LevelManager levelManagerObj;
    public GameObject PointStorer, levelManagerStore, LevelComplete;
    public string WordToSplit;
    public int numerOfObjectToSpawn, Length_of_Word;
    GameObject ThreePointParentStore, FourPointParentStore, FivePointParentStore, SixPointParentStore, SevenPointParentStore, SwapStorer;
    void Awake()
    {
        ThreePointParentStore = GameObject.Find("ThreePoint");
        FourPointParentStore = GameObject.Find("FourPoint");
        FivePointParentStore = GameObject.Find("FivePoint");
        SixPointParentStore = GameObject.Find("SixPoint");
        SevenPointParentStore = GameObject.Find("SevenPoint");
        SwapStorer = GameObject.Find("SWAP");

        SwapStorer.SetActive(false);
        ThreePointParentStore.SetActive(false);
        FourPointParentStore.SetActive(false);
        FivePointParentStore.SetActive(false);
        SixPointParentStore.SetActive(false);
        SevenPointParentStore.SetActive(false);
        levelManagerStore.SetActive(false);
        StartNewLevel();
    }
    public void StartNewLevel()
    {
        WordToSplit = GameObject.Find("Header").transform.GetChild(0).GetComponent<TMP_Text>().text;
        print(WordToSplit);
        Length_of_Word = WordToSplit.Length;
        print("the length of word is " + Length_of_Word);
        numerOfObjectToSpawn = Length_of_Word;
        SwapStorer.SetActive(true);
        if (Length_of_Word == 3)
        {
            PointStorer = ThreePointParentStore;
            PointStorer.SetActive(true);
            levelManagerStore.SetActive(true);

            /*ThreePointParentStore.SetActive(true);*/
        }
        else if (Length_of_Word == 4)
        {
            PointStorer = FourPointParentStore;
            PointStorer.SetActive(true);
            levelManagerStore.SetActive(true);
            /*FourPointParentStore.SetActive(true);*/
        }
        else if (Length_of_Word == 5)
        {
            PointStorer = FivePointParentStore;
            PointStorer.SetActive(true);
            levelManagerStore.SetActive(true);
            /*FivePointParentStore.SetActive(true);*/
        }
        else if (Length_of_Word == 6)
        {
            PointStorer = SixPointParentStore;
            PointStorer.SetActive(true);
            levelManagerStore.SetActive(true);
            /*SixPointParentStore.SetActive(true);*/
        }
        else
        {
            PointStorer = SevenPointParentStore;
            PointStorer.SetActive(true);
            levelManagerStore.SetActive(true);
            /* SevenPointParentStore.SetActive(true);*/
        }
    }

    public void GameOver()
    {
        print("word before change" + WordToSplit);
        WordToSplit = "";
        levelManagerObj.concatenatedString = "";
        print("after change" + WordToSplit);
        GameObject.Find("Header").transform.GetChild(0).GetComponent<TMP_Text>().text = "";
        SwapStorer.SetActive(false);
        LevelComplete.SetActive(true);
        LevelComplete.transform.GetChild(0).GetComponent<Button>().onClick.AddListener(onClickContinue);


    }

    public void onClickContinue()
    {
        LevelComplete.SetActive(false);


        /*ItemScriptObj.lineManagerGameObject.SetActive(false);*/
        PointStorer.SetActive(false);
        levelManagerStore.SetActive(false);

        GameObject.Find("Header").transform.GetChild(0).GetComponent<TMP_Text>().text = "Banana";
        if (WordToSplit != null)
        {
            print("Header is not Empty");
            StartNewLevel();
        }
        else
        {
            print("Header is Empty");
        }
    }


}