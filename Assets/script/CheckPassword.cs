using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckPassword : MonoBehaviour {
	[SerializeField] Text field;
	[SerializeField] int pass = 0;

	public bool checkPassword () {
		if (int.Parse(field.text) == pass)
			return true;
		return false;
	}
}
