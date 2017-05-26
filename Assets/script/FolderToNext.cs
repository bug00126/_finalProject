using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FolderToNext : MonoBehaviour {

	public FolderCheck[] fc;
	[SerializeField] GameObject obj1, obj2;
	bool flag = true;
	public bool checkNextFolder () {
		for (int i=0; i<5; i++) {
			if (!fc[i].flag) flag = false;
		}
		return flag;
	}

	public void react () {
		if (checkNextFolder()) {
			obj1.SetActive(true);
			print("Correct");
		} else {
			obj2.SetActive(false);
			print("Wrong");
		}
	}
}
