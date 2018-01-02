using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollScript : MonoBehaviour {

    public CaseScript cs;

	void Update () {
        gameObject.transform.Translate(new Vector2(cs.scrollSpeed, 0) * Time.deltaTime);
	}
}
