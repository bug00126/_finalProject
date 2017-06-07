using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class StartGame : MonoBehaviour {

	[SerializeField] Image[] image;
	[SerializeField] Text[] text;
	[SerializeField] CanvasGroup canvas;

	void awake() {
		print ("awake");
		image[0].DOFade(1, 1);
		this.myInvoke(1, ()=> {
			image[1].DOFade(1, 1);
		});
		this.myInvoke(2, ()=> {
			for (int i=0; i<2; i++) {
				image[i+2].DOFade(1, 1);
				text[i].DOFade(1, 1);
			}
			canvas.interactable = true;
		});
	}
}
