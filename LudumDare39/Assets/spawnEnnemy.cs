using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnEnnemy : MonoBehaviour {
    private float lieuDeSpawn;
    public GameObject[] whichEnnemy;
    public GameObject ennemy;
    


	// Use this for initialization
	void Start () {
        InvokeRepeating("spawn", 1f, 1f);

	}
	
	// Update is called once per frame
	void Update () {


    }

    void spawn()
    {

        Instantiate(ennemy, Camera.main.ScreenToWorldPoint(new Vector2(Random.Range(0, Screen.width), 0f)), Quaternion.LookRotation(Vector3.back,Vector3.back));
        Instantiate(ennemy, Camera.main.ScreenToWorldPoint(new Vector2(Random.Range(0, Screen.width), Screen.height)), transform.rotation);
    }
}
