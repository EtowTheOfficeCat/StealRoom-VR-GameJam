using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public float TimeLeft = 540;
    private float startTime;
    private bool GameisOver = false;

    [SerializeField] AudioSource Knocking;
    [SerializeField] AudioSource Policeman;

    [SerializeField] GameObject GameOver;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (GameisOver == true)
            return;
        float t = TimeLeft -= Time.deltaTime;

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f0");

        timerText.text = minutes + ":" + seconds;

        if (t < 0)
        {
            StartCoroutine(GameStop());
            t = 0;
            GameisOver = true;
        }
    }

    public IEnumerator GameStop()
    {
        yield return new WaitForSeconds(2);

        GameOver.SetActive(true);
        Knocking.Play();

        yield return new WaitForSeconds(1);
        Policeman.Play();
        Time.timeScale = 0f;


    }
}
