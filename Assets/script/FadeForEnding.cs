using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class FadeForEnding : Fade {

	public Text title, continued;
	public GameObject[] button;
	public float second;

	public GameObject youFail, conti, dead;
	public override void fade() {
		youFail.SetActive(true);
		conti.SetActive(true);
		dead.SetActive(true);
		title.DOFade(0, 0);
		continued.DOFade(0, 0);
		image.DOFade(0, 0);
		

		this.myInvoke(second, ()=> {
			image.DOFade(fadeRate, duration).OnComplete(()=> {
				title.DOFade(fadeRate, duration).OnComplete(()=> {
					continued.DOFade(fadeRate, duration).OnComplete(()=>{
						for (int i=0; i<2; i++) {
							button[i].SetActive(true);
						}
					});
				});
			});
		});
	}

}
