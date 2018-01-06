using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CaseScript : MonoBehaviour {

    public bool openCase = false;
    public GameObject[] prefabs;
    public GameObject sp;
    public float scrollSpeed = -20;
    private float velocity;
    public WSprites[] ws;
    public Image[] prefabImages;

	void Start () {
		
	}

	void Update () {
        if (openCase)
        {
            scrollSpeed = Mathf.MoveTowards(scrollSpeed, 0, velocity * Time.deltaTime);
        }
	}

    public void CaseButton(int caseID)
    {
        openCase = true;
        gameObject.SetActive(true);
        SimulateCase(caseID);
        velocity = Random.RandomRange(50, 60);
    }

    void SimulateCase( int id)
    {
        for(int k = 0; k <=40; k++)
        {
            int rand = Random.Range(0, 1000);
            int randWeapon = 0;

            if(rand <= 500)//60%
            {
                randWeapon = 0;
                prefabImages[randWeapon].sprite = ws[id].blueW[Random.Range(0, ws[0].blueW.Length)];
            }
            else if( rand > 500 && rand <= 800)//30%
            {
                randWeapon = 1;
                prefabImages[randWeapon].sprite = ws[id].greenW[Random.Range(0, ws[0].greenW.Length)];
            }
            else if (rand > 800 && rand <= 900)//10%
            {
                randWeapon = 2;
                prefabImages[randWeapon].sprite = ws[id].purpleW[Random.Range(0, ws[0].purpleW.Length)];

            }
            else if (rand > 900 && rand <= 960)//6%
            {
                randWeapon = 3;
                prefabImages[randWeapon].sprite = ws[id].redW[Random.Range(0, ws[0].redW.Length)];

            }
            else if (rand > 960)//4%
            {
                randWeapon = 4;
                prefabImages[randWeapon].sprite = ws[id].knife[Random.Range(0, ws[0].knife.Length)];
            }

            GameObject obj = Instantiate(prefabs[randWeapon], new Vector2(0, 0), Quaternion.identity) as GameObject;
            obj.transform.SetParent(sp.transform);
            obj.transform.localScale = new Vector2(1, 1);
        }
    }
}
