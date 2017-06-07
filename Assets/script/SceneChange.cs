using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChange : MonoBehaviour {

	[SerializeField] SceneManager sm;
	[SerializeField] float second;
	public void sceneChange() {
		this.myInvoke(second, ()=>{
			sm.LoadScene();
		});
	}
}
