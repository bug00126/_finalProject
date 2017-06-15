using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetClockPins : MonoBehaviour {

	[SerializeField] GameObject[] pin, pins, pinss;
	[SerializeField] PinDetermination pd;

	public void setPinsClockwise() {
		for (int i=0; i<3; i++) {
			if (pd.pinCheck[i]){
				pin[i].transform.Rotate(0, 0, -30);
				pins[i].transform.Rotate(0, 0, -30);
				pinss[i].transform.Rotate(0, 0, -30);
			}
		}
	}

	public void setPinsCounterClockwise() {
		for (int i=0; i<3; i++) {
			if (pd.pinCheck[i]){
				pin[i].transform.Rotate(0, 0, 30);
				pins[i].transform.Rotate(0, 0, 30);
				pinss[i].transform.Rotate(0, 0, 30);
			}
		}
	}
	
}
