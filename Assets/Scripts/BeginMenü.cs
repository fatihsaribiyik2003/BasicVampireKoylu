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
        SceneManager.LoadScene("Firstchoose");
    }
    public void ModaretorplayScene()
    {
        // "Gameplay" sahnesine geçiş yap
        SceneManager.LoadScene("Yonetim");
    }
    public void GeceModaretorplayScene()
    {
        // "Gameplay" sahnesine geçiş yap
        SceneManager.LoadScene("GeceMode");
    }
    public void GunduzModaretorplayScene()
    {
        // "Gameplay" sahnesine geçiş yap
        SceneManager.LoadScene("GunduzMode");
    }
    public void SonrakiYamaScene()
    {
        // "Gameplay" sahnesine geçiş yap
        SceneManager.LoadScene("GelecekGuncellemeler");
    }
    
    
}

