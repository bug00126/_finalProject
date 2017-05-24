using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetUnlockForFolder : SetUnlock {

	[SerializeField] GameObject currentFolder, nextFolder;
	[SerializeField] BoxCollider2D collider;

	public override void react() {
        if (!submit.isUnlock) {
			whileLock.SetActive(true);
			collider.enabled = false;
		} else {
			changeFolder();
		}
	}

	void changeFolder() {
		currentFolder.SetActive(false);
		nextFolder.SetActive(true);
	}
}
