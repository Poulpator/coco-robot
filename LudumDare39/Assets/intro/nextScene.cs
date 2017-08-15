using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class nextScene : MonoBehaviour {
    public VideoPlayer intro;

	
	// Update is called once per frame
	void Update () {
        if (intro.isPlaying == false && Time.time >= 10f)
        {
            SceneManager.LoadScene("scene1");
        }
        


	}

}
