using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class stamina : MonoBehaviour {
    public float endurance;
    public GameObject mainCharacter;

	
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //baisse de l'endurance
        if (Input.GetButton("Fire1"))
        {
           endurance -= 0.75f;
        }
        if (mainCharacter.GetComponent<deplacement>().vitesse >3)
        {
            endurance -= 0.25f;
        }
        
          

        //mort 
        if (endurance < 0f)
        {
            Destroy(mainCharacter);
            SceneManager.LoadScene("propro");
        }

	}
    void OnTriggerEnter2D(Collider2D coll)
    {
        
        Debug.Log(coll.gameObject.name);
        if (coll.gameObject.tag == "ennemy")
        {
            endurance -= 25f;
            Destroy(coll.gameObject);

        }
        else if (coll.gameObject.tag == "batterie")
        {
            endurance += 15f;
            Debug.Log("collision");
            Destroy(coll.gameObject);
        }
        
    }
}
