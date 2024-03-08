using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Buttons : MonoBehaviour
{
   
    public void LoadGameVampirler()
    {
        SceneManager.LoadScene("Vampirler");
    }
    public void LoadGameKoyluler()
    {
        SceneManager.LoadScene("Koyluler");
    }
    public void LoadGameTarafsizlar()
    {
        SceneManager.LoadScene("Tarafsızlar");
    }
    
}

