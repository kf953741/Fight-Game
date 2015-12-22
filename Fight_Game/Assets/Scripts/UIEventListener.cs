using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class UIEventListener : MonoBehaviour ,IPointerClickHandler,IPointerDownHandler,IPointerUpHandler,IDragHandler
{
	public delegate void VoidDelegate(GameObject go);
	public VoidDelegate onClick;
	public VoidDelegate onDown;
	public VoidDelegate onUp;
	public VoidDelegate onDrag;
	public static PointerEventData pointerEventData;
	public static UIEventListener Get(GameObject go)
	{
		UIEventListener listener = go.GetComponent<UIEventListener>();
		if(listener==null)
			listener = go.AddComponent<UIEventListener>();
		return listener;
	}
	public void OnPointerClick (PointerEventData eventData)
	{
		if(onClick!=null)
			onClick(gameObject);
	}
	public void OnPointerDown(PointerEventData eventData)
	{
		pointerEventData = eventData;
		if(onDown!=null)
			onDown(gameObject);
	}
	public void OnPointerUp(PointerEventData eventData)
	{
		pointerEventData = eventData;
		if(onUp!=null)
			onUp(gameObject);
	}
	public void OnDrag(PointerEventData eventData)
	{
		pointerEventData = eventData;
		if(onDrag!=null)
			onDrag(gameObject);
	}
}
