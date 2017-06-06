using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PasswordSubmit : MonoBehaviour {
	public Text[] field;
	public string[] passwd;
	public int size;
	public ChangeImage ci;
	public FolderChange fc;
	[SerializeField] GameObject passwdWindow;

	public bool submitPasswd () {
		for (int i=0; i<size; i++) {
			if (field[i].text != passwd[i]) {
				print ("wrong password!!!");
				return false;
			}
		}
		print ("unlock");
		return true;
	}

	public void react() {
		if (submitPasswd()) {
			passwdWindow.SetActive(false);
			ci.changeImage();
			fc.react();
		}
	}
}
