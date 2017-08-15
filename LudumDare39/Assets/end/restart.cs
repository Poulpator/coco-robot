using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{

    public void Mafonction()
    {

        SceneManager.LoadScene("scene1");
    }
    public void Quite()
    {
        Application.Quit();
    
    }   
    
    
        
    
}

