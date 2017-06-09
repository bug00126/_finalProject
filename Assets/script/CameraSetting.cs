using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSetting : MonoBehaviour {
	public float baseWidth = 1024;
	public float baseHeight = 768;
	public float baseOrthographicSize = 5;
	public Camera camera;

	void awake(){
		print("awake");
    	float newOrthographicSize = (float)Screen.height / (float)Screen.width * this.baseWidth / this.baseHeight * this.baseOrthographicSize;
    	camera.orthographicSize = Mathf.Max(newOrthographicSize , this.baseOrthographicSize);
	}
}
