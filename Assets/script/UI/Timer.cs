using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private Text timerText;

    public GameObject panel;

    public GameObject result;

    private float startTime;

    // Use this for initialization
    void Start()
    {
        panel.SetActive(false); 
        startTime = 300f;
        timerText = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {

        //startTime -= Time.deltaTime;
        if (startTime > 0)
        {
            startTime -= Time.deltaTime;
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

        result.GetComponent<ShowScore>().gameObject.SendMessage("ShowResult", SendMessageOptions.DontRequireReceiver);

        panel.SetActive(true);

    }
}
