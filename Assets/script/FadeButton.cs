using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class FadeButton : Fade {

	[SerializeField] Text text;

	public override void fade() {
		image.DOFade(fadeRate, duration);
		text.DOFade(fadeRate, duration);
	}
}
