using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hit : MonoBehaviour {

    public Image dropImage;
    public GameObject dropPanel;
    public Text droptextName;
    public Text droptexCost;
    public Transform Image;

    public ScrollScript ss;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update()
    {
        

        if (ss.scrollSpeed == 0)
        {
            Vector2 point = Image.position;
            RaycastHit2D hit = Physics2D.Raycast(point, Vector2.zero);
            dropImage.sprite = hit.collider.gameObject.GetComponent<Skin>().image;
            droptextName.text = hit.collider.gameObject.GetComponent<Skin>().nameSkin;
            droptexCost.text = "Cost: " + hit.collider.gameObject.GetComponent<Skin>().cost.ToString() + "$";
            dropPanel.SetActive(true);

        }
        else
        {
            Clear();
        }
    }

    void Clear()
    {
        dropImage.sprite = null;
        droptextName.text = null;
        droptexCost.text = null;
        dropPanel.SetActive(false);
    }
}
