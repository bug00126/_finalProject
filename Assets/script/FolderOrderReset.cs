using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FolderOrderReset : MonoBehaviour {

	[SerializeField] FolderCheck[] fc;
	public void folderOrderReset() {
		for (int i=0; i<5; i++) {
			fc[i].flag = false;
		}
	}
}
