using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour {

	public void NewGameBtn(string gameScene) {
		SceneManager.LoadScene(gameScene);
	}

	public void ExitGameBtn() {
		Application.Quit();
	}
}
