using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageController : MonoBehaviour
{
    public Image[] images; // Resimlerinizi içeren dizi
    private int currentIndex = 0; // Şu anki resim indeksi

    void Start()
    {
        ShowCurrentImage();
    }

    void ShowCurrentImage()
    {
        for (int i = 0; i < images.Length; i++)
        {
            images[i].gameObject.SetActive(i == currentIndex);
        }
    }

    public void NextImage()
    {
        currentIndex = (currentIndex + 1) % images.Length;
        ShowCurrentImage();
    }

    public void PreviousImage()
    {
        currentIndex = (currentIndex - 1 + images.Length) % images.Length;
        ShowCurrentImage();
    }
}
