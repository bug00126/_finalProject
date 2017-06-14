using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class DoorOpen : Fade {

	[SerializeField] SceneChange sc;

	public override void fade() {
		image.DOFade(fadeRate, duration).OnComplete (()=>{
			sc.sceneChange();
		});

	}

}
