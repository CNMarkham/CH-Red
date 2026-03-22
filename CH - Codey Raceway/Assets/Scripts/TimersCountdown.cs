using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimersCountdown : MonoBehaviour
{
    public Text lapTime;
    public Text startCountdown;
    public Text LoseText;

    public float totalLapTime;
    public float totalCountdownTime;

    public void Start()
    {
        LoseText.enabled = false;
    }
    public void laptime()
    {
        
        lapTime.text = Mathf.Round(totalLapTime).ToString();
    }

    public void ReloadScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
    void Update()
    {
        totalCountdownTime -= Time.deltaTime;

        startCountdown.text = Mathf.Round(totalCountdownTime).ToString();

        if (totalCountdownTime <= 0.01f)
        {
            totalLapTime -= Time.deltaTime;
            startCountdown.enabled = false;
            laptime();
        }
        if (totalLapTime <= 0)
        {
            print("you lost");
            lapTime.enabled = false;
            LoseText.enabled = true;
            Invoke("ReloadScene", 3);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            totalLapTime -= 10;
        }
    }
}
