using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeImage : MonoBehaviour {
	[SerializeField] GameObject obj;
	public Sprite sprite;

	Image image;

	void Awake () {
		image = obj.GetComponent<Image>();
	}

	public void changeImage(){
		image.sprite = sprite;
	}
}
