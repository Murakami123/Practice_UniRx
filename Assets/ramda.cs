using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.Events;

public class ramda : MonoBehaviour {

void Start()
{
	var names = new List<string> { "Taro", "Jiro", "Saburo" };
	var actions = new List<Action>();

	foreach (string name in names)
	{
		actions.Add(() =>
		{
			Debug.Log(name);
		});
	}

	foreach(var action in actions)
	{
		action();
	}	
}

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
