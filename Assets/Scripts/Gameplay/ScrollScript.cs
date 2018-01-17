using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScrollScript : MonoBehaviour {

    public float scrollSpeed = -20f;
    public Vector3 startPos;
   

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        scrollSpeed = Mathf.MoveTowards(scrollSpeed, 0f, 3f * Time.deltaTime);

        gameObject.transform.Translate(new Vector2(scrollSpeed, 0) * Time.deltaTime);


    }
   /* void Clear()
    {
        dropImage.sprite = null;
        droptextName.text = null;
        droptexCost.text = null;
        dropPanel.SetActive(false);
    }*/
    public void StartPos()
    {
        gameObject.transform.localPosition = startPos;
    }
}
