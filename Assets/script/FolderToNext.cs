using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FolderToNext : MonoBehaviour {

	public FolderCheck[] fc;
	[SerializeField] GameObject correctFolder, wrongFolder, currentFolder;
	GameObject nextFolder;
	public bool checkNextFolder () {
		for (int i=0; i<5; i++) {
			if (!fc[i].flag) return false;
		}
		return true;
	}

	public void folderChange() {
		currentFolder.SetActive(false);
		nextFolder.SetActive(true);
	}

	public void react () {
		nextFolder = (checkNextFolder())? correctFolder : wrongFolder;
		print((checkNextFolder())? "correct" : "wrong");
		folderChange();
	}
}
