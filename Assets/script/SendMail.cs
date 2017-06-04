using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SendMail : MonoBehaviour {

	[SerializeField] GameObject obj, icon;
	[SerializeField] Text text;
	private float second = 3.0f;

	public void sendmail() {
		if (text.text == "MJslagman@dpp.org.tw") {
			this.myInvoke (second, ()=> {
				obj.SetActive(true);
				icon.SetActive(true);
			});
		}
	}
}
