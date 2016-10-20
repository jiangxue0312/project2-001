using UnityEngine;
using UnityEngine.UI;

public class ShowScore : MonoBehaviour {

    private Text endText;

    // Use this for initialization
    void Start () {
        endText = GetComponent<Text>();
    }
	
	public void ShowResult () {
        int score = PointManager.Instance.GetPoint();
        endText.text = "Congratulations! You have completed the whack a mole game.\n" +
            "Your final score is " + score + ".Thank you!";

    }
}
