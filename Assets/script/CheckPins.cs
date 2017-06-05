using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPins : MonoBehaviour {

	[SerializeField] GameObject[] obj;

	int[] ans = {330, 180, 150};

	public bool checkPins() {
		bool flag = true;
		for (int i=0; i<3; i++) {
			if (obj[i].transform.eulerAngles.z != ans[i]) {
				print(i+" "+obj[i].transform.eulerAngles.z+" "+obj[i].transform.rotation.z);
				flag = false;
			}
		}
		return flag;
	}

	[SerializeField] GameObject doorSetting, window;

	public void react() {
		if (checkPins()) {
			doorSetting.SetActive(true);
			window.SetActive(false);
			print ("door unlock");
		} else {
			print ("pins position wrong!");
			for (int i=0; i<3; i++) {
				print(obj[i].transform.eulerAngles.z);
			}
		}
	}
}
