using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PointManager : MonoBehaviour {

    public static PointManager Instance;

    private int point = 0;
    private Text scoreText;

    // Use this for initialization
    void Start()
    {
        Instance = this;
        scoreText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = point.ToString();
    }

    public void IncrementPoint()
    {
        point += 10;
    }

    public int GetPoint()
    {
        return point;
    }

    void OnDisable()
    {
        Instance = null;
    }
}
