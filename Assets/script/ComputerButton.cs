using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerButton : MonoBehaviour {

	[SerializeField] GameObject canvas;

	public void react() {
		if (!PasswordSubmit.isUnlock) {
			canvas.SetActive(true);
		} else {

		}
	}
}
