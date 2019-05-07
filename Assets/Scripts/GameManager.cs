using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public ScoreKeeper Score;
    public LivesTracker Lives;
    float timer;
    private void Start()
    {
        timer = Time.deltaTime;
    }
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        //after 1 second...
        if (timer >= 1f)
        {
            Score.IncreaseScore();
            Lives.DecreaseLives();
            timer = Time.deltaTime;
        }
    }
}
