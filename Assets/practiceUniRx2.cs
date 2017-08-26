using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UniRx;
using UniRx.Triggers;	

public class practiceUniRx2 : MonoBehaviour
, IPointerDownHandler
, IPointerUpHandler 
, IPointerClickHandler 
// , IDragHandler
// , IBeginDragHandler
// , IEndDragHandler
,ISelectHandler
,IDeselectHandler

{


	Button button;

	void Start()
	{
		button = GetComponent<Button>();
		// ポインターアップで実行するやつ
		button.OnPointerUpAsObservable()
		.Subscribe( _ => {
			Debug.Log("OnPointerUpしたよ");
		});

		// 毎秒実行するやつ
		// Observable.Interval(System.TimeSpan.FromSeconds(1.0f))
		// .Subscribe(
		// 	count => { //OnNext
		// 		Debug.Log("count = " + count.ToString());
		// 	}
		// 	// ,e => { // OnError
		// 	// 	Debug.Log(e.Message);
		// 	// }
		// 	// ,() => { // OnCompleted
		// 	// 	Debug.Log("Completed!");
		// 	// }
		// );
	}

//------------------------------------------------------------------
// EventTriggerからよべるやつ
//------------------------------------------------------------------
	public void OnPointerUp(){
		Debug.Log("OnPointerUpのイベントトリガー");
	}

//------------------------------------------------------------------
// イベント系インターフェイスから呼べるやつ
//------------------------------------------------------------------
    public void OnPointerDown(PointerEventData eventData){
        Debug.Log("OnPointerDown イベントです！");
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log("IPointerUpHandler イベントです！");
    }

	public void OnPointerClick(PointerEventData eventData){
        Debug.Log("OnPointerClick イベントです！");

	}

	// OnDragを使ってるとスクロールできなくなるので、使えない。
	// OnDragを使ってないとOnBeginDrag, OnEndDrag も使えないしょうがない。
	// public void OnDrag(PointerEventData eventData){
    //     Debug.Log("OnDrag イベントです！");

	// }
	// public void OnBeginDrag(PointerEventData eventData){
    //     Debug.Log("OnBeginDrag イベントです！");

	// }

	// public void OnEndDrag(PointerEventData eventData){
    //     Debug.Log("OnEndDrag イベントです！");
	// }
	public void OnSelect(BaseEventData eventData){
        Debug.Log("OnSelect イベントです！");

	}
	public void OnDeselect(BaseEventData eventData){
        Debug.Log("OnDeselect イベントです！");

	}

}
