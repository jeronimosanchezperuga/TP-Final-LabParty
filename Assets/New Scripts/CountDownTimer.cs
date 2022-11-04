using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountDownTimer : MonoBehaviour
{
    public static float currentTime = 0f;
    float startingTime = 40f;
    [SerializeField] TextMeshProUGUI countdownText;

    public static bool timesUp = false;

    void Start()
    {
        timesUp = false;
        currentTime = startingTime;
    }

    void Update()
    {
        if (LogicaNPC.check3 == true)
        {
            currentTime -= 1 * Time.deltaTime;
            countdownText.text = currentTime.ToString("0");

            if (currentTime <= 0)
            {
                currentTime = 0;
            }

            if (currentTime <= 10)
            {
                countdownText.color = Color.red;
            }

            if (currentTime == 0)
            {
                timesUp = true;
            }
        }
    }
}
