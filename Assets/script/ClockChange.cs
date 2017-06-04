using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockChange : MonoBehaviour {

	[SerializeField] GameObject clockPass;
	[SerializeField] CheckPins cp;
	[SerializeField] Canvas canvas;
	

	public void clockChange() {
		CanvasGroup cg = canvas.GetComponent<CanvasGroup>();
		if (!cp.checkPins()) {
			clockPass.SetActive(true);
			cg.interactable = false;
		}
	}
}
