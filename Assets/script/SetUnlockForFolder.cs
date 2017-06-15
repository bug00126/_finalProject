using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetUnlockForFolder : SetUnlock {

	[SerializeField] GameObject currentFolder, nextFolder, realFolder;
	[SerializeField] DragWindow dw;
	[SerializeField] FolderToNext ftn;

	public override void react() {
        if (!submit.submitPasswd()) {
			whileLock.SetActive(true);
			dw.enabled = false;
		} else {
			if (ftn.checkNextFolder())
				nextFolder = realFolder;
			changeFolder();
		}
	}

	void changeFolder() {
		currentFolder.SetActive(false);
		nextFolder.SetActive(true);
	}
}
