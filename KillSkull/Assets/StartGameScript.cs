using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartGameScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void PressButton() {
        SceneManager.LoadScene("MainScene");
    }

    public void PressQuitButton()
    {
        Application.Quit();
    }
}
