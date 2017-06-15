using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fail : MonoBehaviour {

	public float second;
	public GameObject obj;

	public void react() {
		this.myInvoke(second, ()=>{
			obj.SetActive(true);
		});
	}
}
