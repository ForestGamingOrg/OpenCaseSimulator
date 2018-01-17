using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CsGoCaseSimulate : MonoBehaviour {

    public CsGoSkins caseSkins;
    public GameObject prefab;
    public GameObject parrent;
    public GameObject ItemsList;
    public GameObject obj;
    public int rand;
    public int CaseID;
    public Sprite ImageCase;
    public Image imageUI;

    public ScrollScript ss;
    

    void Start () {
		
	}
	
	void Update () {
        
        
        

    }

    public void OpenButton()
    {
        Clear();
        ClearItems();
        AddSkins();
        SimulateCase();
        
    }
    public void ButtonCase()
    {
        
    }
    public void SimulateCase()
    {

        ss.scrollSpeed = -20f;
        ss.StartPos();
        for (int i = 0; i <= 40; i++)
        {
            rand = Random.Range(0, 1000);
            int randomSkin = 0;

            if (rand <= 800)
            {
                randomSkin = Random.Range(0, caseSkins.blueSkins.Length - 1);
                prefab = caseSkins.blueSkins[randomSkin].gameObject;
                obj = Instantiate(prefab, new Vector2(0, 0), Quaternion.identity, parrent.transform) as GameObject;
            }
            else if (rand > 800 && rand <= 960)
            {
                randomSkin = Random.Range(0, caseSkins.purpleSkins.Length - 1);
                prefab = caseSkins.purpleSkins[randomSkin].gameObject;
                obj = Instantiate(prefab, new Vector2(0, 0), Quaternion.identity, parrent.transform) as GameObject;
            }
            else if (rand > 960 && rand <= 990)
            {
                randomSkin = Random.Range(0, caseSkins.pinkSkins.Length - 1);
                prefab = caseSkins.pinkSkins[randomSkin].gameObject;
                obj = Instantiate(prefab, new Vector2(0, 0), Quaternion.identity, parrent.transform) as GameObject;
            }
            else if (rand > 990 && rand <= 996)
            {
                randomSkin = Random.Range(0, caseSkins.redSkins.Length - 1);
                prefab = caseSkins.redSkins[randomSkin].gameObject;
                obj = Instantiate(prefab, new Vector2(0, 0), Quaternion.identity, parrent.transform) as GameObject;
            }
            else if (rand > 996)
            {
                randomSkin = Random.Range(0, caseSkins.knifeSkins.Length - 1);
                prefab = caseSkins.knifeSkins[randomSkin].gameObject;
                obj = Instantiate(prefab, new Vector2(0, 0), Quaternion.identity, parrent.transform) as GameObject;
            }


        }
       
        
    }

    public void AddSkins()
    {

            imageUI.sprite = ImageCase;
            for (int k = 0; k < caseSkins.blueSkins.Length; k++)
            {
               prefab = caseSkins.blueSkins[k].gameObject;
                obj =  Instantiate(prefab, new Vector2(0, 0), Quaternion.identity, ItemsList.transform) as GameObject;
            }
            for (int k = 0; k < caseSkins.purpleSkins.Length; k++)
            {
                prefab = caseSkins.purpleSkins[k].gameObject;
                 obj = Instantiate(prefab, new Vector2(0, 0), Quaternion.identity, ItemsList.transform) as GameObject;
            }
            for (int k = 0; k < caseSkins.pinkSkins.Length; k++)
            {
                prefab = caseSkins.pinkSkins[k].gameObject;
                 obj  =Instantiate(prefab, new Vector2(0, 0), Quaternion.identity, ItemsList.transform) as GameObject;
            }
            for (int k = 0; k < caseSkins.redSkins.Length; k++)
            {
                prefab = caseSkins.redSkins[k].gameObject;
                 obj = Instantiate(prefab, new Vector2(0, 0), Quaternion.identity, ItemsList.transform) as GameObject;
            }
            for (int k = 0; k < caseSkins.knifeSkins.Length; k++)
            {
                prefab = caseSkins.knifeSkins[k].gameObject;
                 obj = Instantiate(prefab, new Vector2(0, 0), Quaternion.identity, ItemsList.transform) as GameObject;
            }
        
    }

    void Clear()
    {
        foreach (Transform child in parrent.transform)
        {
            GameObject.Destroy(child.gameObject);
            Debug.Log("Удалено");
        }
    }

    void ClearItems()
    {
        foreach (Transform child in ItemsList.transform)
        {
            GameObject.Destroy(child.gameObject);
            Debug.Log("Удалено");
        }
    }
}
