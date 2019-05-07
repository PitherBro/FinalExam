using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimeKeeper : MonoBehaviour
{
    public Text Display;
    float curTime;
    float timer;
    private void Start()
    {
        Settings.gameTime = 60;
        curTime = Settings.gameTime;

        Display.text = curTime.ToString();
        timer = Time.deltaTime;
    }
    void Update()
    {
        timer += Time.deltaTime;
        //after 1 second...
        if (timer >= 1f)
        {
            curTime--;
            Display.text = curTime.ToString();
            timer = Time.deltaTime;
        }
    }
}
