using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FolderChange : MonoBehaviour {

	[SerializeField] GameObject currentFolder, nextFolder;

	public void react() {
		currentFolder.SetActive(false);
		nextFolder.SetActive(true);
	}
}
