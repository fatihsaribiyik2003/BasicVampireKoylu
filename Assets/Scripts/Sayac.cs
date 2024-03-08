using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Sayac : MonoBehaviour
{
    public TMP_Text timerText;
    public UnityEngine.UI.Button startButton;
    public float countdownDuration = 120f; // 2 dakika (saniye cinsinden)
    private float currentTime;
    public AudioSource audioSource;
    private bool countingDown = false;

    void Start()
    {
        currentTime = countdownDuration;
        UpdateTimerText();
        startButton.onClick.AddListener(StartCountdown);
    }

    void Update()
    {
        if (countingDown && currentTime > 0f)
        {
            currentTime -= Time.deltaTime;

            // Negatif değer kontrolü
            currentTime = Mathf.Max(currentTime, 0f);

            UpdateTimerText();

            if (currentTime == 0f)
            {
                countingDown = false;
                // Sayaç 00:00 olduğunda başka bir işlem yapabilirsiniz
                Debug.Log("Countdown finished!");
                audioSource.Play();
                
            }
            if (currentTime <= 15f && currentTime > 0f)
            {
                Debug.Log("15 saniye kaldı sesi eklenecek");
            }
        }
    }

    void UpdateTimerText()
    {
        int minutes = Mathf.FloorToInt(currentTime / 60f);
        int seconds = Mathf.FloorToInt(currentTime % 60f);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void StartCountdown()
    {
        countingDown = true;
    }
}
