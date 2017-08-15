using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tir : MonoBehaviour {
    Ray2D ray;
    RaycastHit2D hit;
    Vector2 devant;
    public GameObject batterie;
    public float portéeDuTir;

	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Fire1"))
        {

            gameObject.GetComponent<LineRenderer>().enabled = true;
            devant = transform.TransformDirection(Vector2.up);
            ray = new Ray2D(transform.position, devant);
            Debug.DrawRay(ray.origin, ray.direction * 200f);


            hit = Physics2D.Raycast(ray.origin, ray.direction);
            if (hit.collider != null && hit.collider.name != "collider"&& hit.collider.tag != "batterie" && hit.distance < 15f)
            {
               // Debug.Log("hit qlque chose");
                Destroy(hit.collider.gameObject);
                if (Random.Range(0f, 1f) < 0.5f)
                {
                    Instantiate(batterie, hit.transform.position, Quaternion.identity);
                }
            }
        }

        if (Input.GetButtonDown("Fire1"))
            {
                transform.parent.Translate(new Vector2(0, -1)*10f*Time.deltaTime);
               
            }
          if (Input.GetButtonUp("Fire1"))
            {
                gameObject.GetComponent<LineRenderer>().enabled = false;
            }
        }

        
	
}
