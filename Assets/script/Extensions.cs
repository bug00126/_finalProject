
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public static class Extensions{
//System.Action is any "function"
  public static void myInvoke(this MonoBehaviour mb, float seconds,System.Action completeEvent)
  {
      mb.StartCoroutine(waitSeconds(seconds,completeEvent));
  }
  public static IEnumerator waitSeconds(float seconds,System.Action completeEvent)
  {
      yield return new WaitForSeconds(seconds);
      completeEvent();
  }
}