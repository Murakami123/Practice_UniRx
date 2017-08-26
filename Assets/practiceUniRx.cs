using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx; // 追加

public class practiceUniRx : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Observable.Interval(System.TimeSpan.FromSeconds(1.0f))
			.Subscribe(
				count => { //OnNext
					Debug.Log("count = " + count.ToString());
				}
				// ,e => { // OnError
				// 	Debug.Log(e.Message);
				// }
				// ,() => { // OnCompleted
				// 	Debug.Log("Completed!");
				// }
			);
	}
	
	// Update is called once per frame
	// void Update () {}
}
