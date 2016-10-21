using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private Text timerText;

    public GameObject panel;

    public GameObject result;

    public GameObject addTimePanel;

    private float startTime;

    public static Timer Instance;


    bool freezeTime;

    // Use this for initialization
    void Start()
    {
        freezeTime = false;
        panel.SetActive(false); 
        startTime = 300f;
        timerText = GetComponent<Text>();
        Instance = this;

    }

    // Update is called once per frame
    void Update()
    {

        //startTime -= Time.deltaTime;
        if (startTime > 0)
        {
            if (freezeTime)
            {
                startTime += 2f;
                addTimePanel.GetComponent<Animator>().SetTrigger("PanelShow");
                freezeTime = false;
            }
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

    public void AddTime()
    {
        freezeTime = true;
    }
}
