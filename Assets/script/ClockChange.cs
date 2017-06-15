using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockChange : SetUnlock {

	[SerializeField] CheckPins cp;
	[SerializeField] GameObject[] pin, pins, pinss;
	

	public override void react() {
		if (!submit.submitPasswd()) {
			whileUnlock.SetActive(true);
		} else {
			if (!cp.checkPins()) {
				whileLock.SetActive(true);
				for (int i=0; i<3; i++) {
					pin[i].transform.eulerAngles = new Vector3(0, 0, 180);
					pins[i].transform.eulerAngles = new Vector3(0, 0, 180);
					pinss[i].transform.eulerAngles = new Vector3(0, 0, 180);
				}
			} else {
				whileUnlock.SetActive(true);
			}
		}
	}
}
