using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
//using UniRx;
//using UniRx.Triggers;	

public class dobuletest2 : MonoBehaviour {

	// [SerializeField] 
	// [System.NonSerialized] public ;
	// [Header("ヘッダーです")] 

//-----------------------------------------------
// 処理
//-----------------------------------------------
	public void Initialize(){
		Debug.Log("初期化メソッドです");
	}

//-----------------------------------------------
// ボタンを押したときの処理
//-----------------------------------------------
	public void OnBtnTouch(){
		Debug.Log("ボタンをタッチしました");
	}
}
