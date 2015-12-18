using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class UIEventListener : MonoBehaviour ,IPointerClickHandler
{
	public delegate void VoidDelegate(GameObject go);
	public VoidDelegate onClick;
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
}
