using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeginMenü : MonoBehaviour
{
    // Bu fonksiyon Play tuşuna basıldığında çağrılacak
    public void LoadGameplayScene()
    {
        // "Gameplay" sahnesine geçiş yap
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
    
    
}

