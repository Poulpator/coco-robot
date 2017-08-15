using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class essai : MonoBehaviour {


	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Fire2"))
        {
            Debug.Log("fire2");
            gameObject.SetActive(false);
        }
	}
}
