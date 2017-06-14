using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Ending : MonoBehaviour {

	[SerializeField] Fade[] fade;
	[SerializeField] GameObject[] text;
	[SerializeField] float[] second;

	void Awake() {
		this.myInvoke(second[0], ()=> {
			fade[0].fade();
		});
		this.myInvoke(second[1], ()=> {
			fade[1].fade();
		});
		this.myInvoke(second[2], ()=> {
			fade[2].fade();
		});

		this.myInvoke(second[3], ()=> {
			text[0].SetActive(true);
		});
		this.myInvoke(second[4], ()=>{
			text[0].SetActive(false);
		});

		this.myInvoke(second[5], ()=>{
			text[1].SetActive(true);
		});
		this.myInvoke(second[6], ()=>{
			text[1].SetActive(false);
		});

		this.myInvoke(second[7], ()=>{
			text[2].SetActive(true);
		});
		this.myInvoke(second[8], ()=>{
			text[2].SetActive(false);
		});

		this.myInvoke(second[9], ()=>{
			text[3].SetActive(true);
		});
		this.myInvoke(second[10], ()=>{
			text[3].SetActive(false);
		});

		this.myInvoke(second[11], ()=>{
			text[4].SetActive(true);
		});
		this.myInvoke(second[12], ()=>{
			text[4].SetActive(false);
		});

		this.myInvoke(second[13], ()=>{
			text[5].SetActive(true);
		});
		this.myInvoke(second[14], ()=>{
			text[5].SetActive(false);
		});

		this.myInvoke(second[15], ()=>{
			text[6].SetActive(true);
		});
		this.myInvoke(second[16], ()=>{
			text[6].SetActive(false);
		});

		this.myInvoke(second[17], ()=>{
			text[7].SetActive(true);
		});
		this.myInvoke(second[18], ()=>{
			text[7].SetActive(false);
		});

		this.myInvoke(second[19], ()=>{
			text[8].SetActive(true);
		});
		this.myInvoke(second[20], ()=>{
			text[8].SetActive(false);
		});

		this.myInvoke(second[21], ()=>{
			text[9].SetActive(true);
		});
		this.myInvoke(second[22], ()=>{
			text[9].GetComponent<Text>().DOFade(0, 1);
		});
	}
}
