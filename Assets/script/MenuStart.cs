using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuStart : MonoBehaviour {

	[SerializeField] Fade[] fade;
	[SerializeField] FadeInAndOut fadeInAndOut;
	[SerializeField] Text text;
	[SerializeField] float[] second;

	public void animationStart() {
		fade[0].fade();
		fade[1].fade();
		this.myInvoke(second[0], ()=> {
			fade[2].fade();
		});
		this.myInvoke(second[1], ()=> {
			fade[3].fade();
		});
		this.myInvoke(second[2], ()=> {
			fadeInAndOut.fade(text);
		});
		this.myInvoke(second[3], ()=> {
			fade[4].fade();
		});
		this.myInvoke(second[4], ()=> {
			fade[5].fade();
		});
		this.myInvoke(second[5], ()=> {
			fade[6].fade();
		});
		this.myInvoke(second[6], ()=> {
			fade[7].fade();
		});
	}
}
