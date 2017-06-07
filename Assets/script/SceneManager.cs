using UnityEngine;
//using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour {

	[SceneMenu]
	public string nextScene;

	public void LoadScene(){
		UnityEngine.SceneManagement.SceneManager.LoadScene(this.nextScene);
		//Application.LoadLevel(this.nextScene);
	}
}