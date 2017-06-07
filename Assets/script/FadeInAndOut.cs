using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class FadeInAndOut : Fade {

	public float fadeRate2, second, duration2;

	public override void fade() {
		image.DOFade(fadeRate, duration).OnComplete (()=> {
			this.myInvoke(second, ()=> {
				image.DOFade(fadeRate2, duration2);
			});
		});

	}

	public void fade(Text text) {
		text.DOFade(fadeRate, duration);
		image.DOFade(fadeRate, duration).OnComplete (()=> {
			this.myInvoke(second, ()=> {
				image.DOFade(fadeRate2, duration);
				text.DOFade(fadeRate2, duration);
			});
		});
	}
}
