using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueYesOrNo : MonoBehaviour {

	public List<GameObject> obj = new List<GameObject>();
	public SceneChange sc;

	public void react () {
		for (int i=0; i<obj.Count; i++) {
			obj[i].SetActive(false);
		}
	}

	public void react2() {
		for (int i=0; i<obj.Count; i++) {
			obj[i].SetActive(false);
		}
		sc.sceneChange();
	}
}
