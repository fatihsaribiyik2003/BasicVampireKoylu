using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageControllerAnimation : MonoBehaviour
{
    public Image[] images; // Resimlerinizi içeren dizi
    private int currentIndex = 0; // Şu anki resim indeksi
    public float interval = 5f; // Otomatik geçiş süresi (5 saniye)
    public float fadeDuration = 1f; // Geçiş süresi (1 saniye)

    void Start()
    {
        ShowCurrentImage();
        // Belirtilen sürede bir metodu çağırarak otomatik geçişi sağla
        InvokeRepeating("AutoNextImage", interval, interval);
    }

    void ShowCurrentImage()
    {
        for (int i = 0; i < images.Length; i++)
        {
            if (i == currentIndex)
            {
                // Seçili resmi opak hale getir
                images[i].CrossFadeAlpha(1f, fadeDuration, false);
            }
            else
            {
                // Diğer resimleri saydam hale getir
                images[i].CrossFadeAlpha(0f, fadeDuration, false);
            }
        }
    }

    void AutoNextImage()
    {
        currentIndex = (currentIndex + 1) % images.Length;
        ShowCurrentImage();
    }

    public void NextImage()
    {
        // Elle bir sonraki resme geçiş
        currentIndex = (currentIndex + 1) % images.Length;
        ShowCurrentImage();
    }

    public void PreviousImage()
    {
        // Elle bir önceki resme geçiş
        currentIndex = (currentIndex - 1 + images.Length) % images.Length;
        ShowCurrentImage();
    }
}