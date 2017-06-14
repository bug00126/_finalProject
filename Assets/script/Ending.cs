using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Ending : MonoBehaviour {

	[SerializeField] Image[] image;
	[SerializeField] Text[] text;
	[SerializeField] CanvasGroup canvas;

	void Awake() {
		print ("awake");
		this.myInvoke(1.52f, ()=> {
			image[0].DOFade(1, 1);
		});
		this.myInvoke(3.02f, ()=> {
			image[1].DOFade(1, 1);
		});
		this.myInvoke(4.52f, ()=> {
			image[2].DOFade(1, 1);
			text[0].DOFade(1, 1);
			image[3].DOFade(1, 1);
			text[1].DOFade(1, 1);
			canvas.interactable = true;
		});
	}
}
