using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPins : MonoBehaviour {

	[SerializeField] GameObject[] obj;
	[SerializeField] GameObject funcClock, unfuncClock;
	[SerializeField] Canvas canvas;

	int[] ans = {180, 150, 330};

	public bool checkPins() {
		for (int i=0; i<3; i++) {
			while (obj[i].transform.rotation.z < 0)
				obj[i].transform.Rotate(0, 0, 360);
			if (obj[i].transform.rotation.eulerAngles.z != ans[i]) {
				print(obj[i].transform.eulerAngles.z);
				return false;
			}
		}

		return true;
	}

	[SerializeField] GameObject doorSetting, window;

	public void react() {
		CanvasGroup cg = canvas.GetComponent<CanvasGroup>();
		if (checkPins()) {
			doorSetting.SetActive(true);
			window.SetActive(false);
			funcClock.SetActive(false);
			unfuncClock.SetActive(true);
			cg.interactable = true;
			print ("door unlock");
		} else {
			print ("pins position wrong!");
			for (int i=0; i<3; i++) {
				print(obj[i].transform.eulerAngles.z);
			}
		}
	}
}
