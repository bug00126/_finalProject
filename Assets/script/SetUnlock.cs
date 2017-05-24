using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetUnlock : MonoBehaviour {

	public GameObject whileLock, whileUnlock;
	public PasswordSubmit submit;

	virtual public void react() {
		if (!submit.isUnlock) {
			whileLock.SetActive(true);
		} else {
			whileUnlock.SetActive(true);
		}
	}
}
