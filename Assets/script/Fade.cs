using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Fade : MonoBehaviour {

	public Image image;
	public float fadeRate, duration;

	virtual public void fade() {
		image.DOFade(fadeRate, duration);
	}
}
