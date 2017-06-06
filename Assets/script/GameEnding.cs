using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnding : MonoBehaviour {

	public float seconds = 3.0f;
	[SerializeField] GameObject obj;
	public void react () {
		this.myInvoke(seconds, ()=>{
			obj.SetActive(true);
		});
	}
}
