using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    public Text timerText;

    private float startTime = 30f;

    // Use this for initialization
    void Start()
    {

        timerText = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {

        //startTime -= Time.deltaTime;
        if (startTime > 0)
        {
            startTime = 10f - Time.time;
        }
        else
        
        
        {
            GameOver();
        }

        timerText.text = startTime.ToString("0.0");

    }

    void GameOver()
    {
        Debug.Log("game over");

        if (PointManager.Instance.GetPoint() > 50)
            Win();
        else
            Lose();

    }

    private void Win()
    {
        timerText.text = "You Win!";
    }

    private void Lose()
    {
        timerText.text = "You Lose!";
    }
}
