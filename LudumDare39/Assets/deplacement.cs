using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deplacement : MonoBehaviour {
    public float[] speed;
    public float rotSpeed;
    public int vitesse = 1;
    public GameObject particuleSysteme;


/*
    void Start () {
        for(int i= 0; i < 5; i++)
        {
            Debug.Log(speed[i]);
        }
        

	}
*/
    // Update is called once per frame
    void Update() {
        setParticule();
        //vitesse
        if (Input.GetKeyDown(KeyCode.W) && vitesse < 4)
        {
            vitesse++;
        }

        if (Input.GetKeyDown(KeyCode.S) && vitesse > 0)
        {
            vitesse--;
        }


        transform.Translate(new Vector2(0, speed[vitesse]) * Time.deltaTime * 4f);

        //rotation 
        transform.Rotate(new Vector3(-Input.GetAxisRaw("Horizontal"),0 , 0) * Time.deltaTime * rotSpeed);

    }

    void setParticule()
    {
        if (vitesse >1)
        {
            particuleSysteme.SetActive(true);
        }
        else
        {
            particuleSysteme.SetActive(false);
        }
    }

}
