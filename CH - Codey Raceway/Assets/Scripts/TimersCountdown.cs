using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimersCountdown : MonoBehaviour
{
    public Text lapTime;
    public Text startCountdown;

    public float totalLapTime;
    public float totalCountdownTime;

    public void laptime()
    {
        
        lapTime.text = Mathf.Round(totalLapTime).ToString();
    }

    void Update()
    {
        
        totalCountdownTime -= Time.deltaTime;
        totalLapTime -= Time.deltaTime;

        Invoke(nameof(laptime), 3.0f);

        if (totalCountdownTime <= 0.01f)
        {
            startCountdown.text = Mathf.Round(totalCountdownTime).ToString();
            Destroy(startCountdown);
        }
        else
        {
            
        }
    }
}
