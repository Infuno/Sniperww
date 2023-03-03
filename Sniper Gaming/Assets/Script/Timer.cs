using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float MaxTime;
    public static float CurrentTime;
    public Text text;
    public static bool TimeStop = false;

    public GameObject NowOrNever;
    public GameObject Fail;
    public GameObject FailPanel;
    public GameObject CompletePanel;

    public static bool IsHit = false;
    void Start()
    {
        CurrentTime = MaxTime;
        IsHit = false;
        TimeStop = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        string stringtime = CurrentTime.ToString("0.00");
        text.text = stringtime;
        if(TimeStop == false)
        {
            CurrentTime -= Time.deltaTime;
        }
        if (CurrentTime <= 10)
        {
            text.color = Color.red;
        }
        if (CurrentTime <= 7)
        {
            NowOrNever.SetActive(true);
        }
        if(CurrentTime <= 0)
        {
            Fail.SetActive(true);
            FailPanel.SetActive(true);
            Time.timeScale = 0;
            text.text = ("0.00");
        }

        if(IsHit == true)
        {
            CompletePanel.SetActive(true);
            Time.timeScale = 0;
        }
    }

    
}
