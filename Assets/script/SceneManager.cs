using UnityEngine;

public class SceneManager : MonoBehaviour {

	[SceneMenu]
	public string nextScene;

	public void LoadScene(){
		
		Application.LoadLevel(this.nextScene);
	}
}