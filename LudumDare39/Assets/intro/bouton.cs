using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bouton : MonoBehaviour {

    public void fonction()
    {

        SceneManager.LoadScene("lvl0");
    }
    public void quit()
    {
        Application.Quit();

    }

}

