using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinDetermination : MonoBehaviour {

	public bool[] pinCheck = {false, false, false};

	public void triPin() {
		for (int i=0; i<3; i++) {
			if (i==0) {
				pinCheck[i] = true;
				print ("triangle");
			}
			else
				pinCheck[i] = false;
		}
	}

	public void squPin() {
		for (int i=0; i<3; i++) {
			if (i==1) {
				pinCheck[i] = true;
				print ("square");
			}
			else
				pinCheck[i] = false;
		}
	}

	public void pentaPin() {
		for (int i=0; i<3; i++) {
			if (i==2) {
				pinCheck[i] = true;
				print ("pentagon");
			}
			else
				pinCheck[i] = false;
		}
	}
}
