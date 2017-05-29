using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetUnlockForFolder : SetUnlock {

	[SerializeField] GameObject currentFolder, nextFolder, realFolder;
	[SerializeField] BoxCollider2D collider;
	[SerializeField] FolderToNext ftn;

	public override void react() {
        if (!submit.isUnlock) {
			whileLock.SetActive(true);
			collider.enabled = false;
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
