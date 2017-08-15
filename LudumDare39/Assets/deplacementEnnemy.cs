using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deplacementEnnemy : MonoBehaviour {

	// Use this for initialization
	void Start () {
        InvokeRepeating("move", 0f, 0.05f);
        InvokeRepeating("rotation", 0f, 1);

    }
	
	// Update is called once per frame
	void Update () {

    }

    void move(){
        Vector2 direction = Vector2.right * Time.deltaTime * 10;
        //transform.position += new Vector3(direction.x, direction.y, 0f);
        transform.Translate(direction);
        transform.position = new Vector3(transform.position.x,transform.position.y,0f);
    }
    void rotation()
    {

        transform.Rotate(Vector3.forward,Random.Range(0f,361f));
    }
    /*IEnumerator waitAndsee()
    {
        print(Time.time);
        WaitForSeconds();
    }*/
}
