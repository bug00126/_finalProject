using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PasswordSubmit : MonoBehaviour {
	[SerializeField] Text[] field;
	[SerializeField] int[] passwd = {0, 0, 0};
	GameObject canvas, passwdWindow;
	//Image button;

	void Awake () {
		canvas = GameObject.Find("Canvas_passForComputer");
		passwdWindow = GameObject.Find("computer_pass_block");
		//button = Image.Find("computer_button");
	}

	public bool submitPasswd () {
		bool flag = true;
		for (int i=0; i<3; i++) {
			if (int.Parse(field[i].text) != passwd[i]) {
				flag = false;
			}
		}

		if (flag)
			print ("unlock");
		else
			print ("wrong password!!!");

		return flag;
	}

	public void react() {
		if (submitPasswd()) {
			canvas.SetActive(false);
			passwdWindow.SetActive(false);
			//utton.Image.sprite = "1173763";
		} else {

		}
	}
}
