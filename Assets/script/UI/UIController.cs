using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour {

	public void GameStart () {
        SceneManager.LoadScene("main");
	}

    public void ExitGame()
    {
        Application.Quit();
    }

    public void ReturnMenu()
    {
        SceneManager.LoadScene("start");
    }
}
