using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Joystick : MonoBehaviour {

	// Use this for initialization
	private GameObject joystick;
	public static float v;
	public static float h;
	void Start () {
		joystick = transform.Find("btn_Joystick").gameObject;
		UIEventListener.Get(gameObject).onDown = OnDownJoystick;
		UIEventListener.Get(gameObject).onUp = OnUpJoystick;
		UIEventListener.Get(gameObject).onDrag = OnDragJoystick;

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnDownJoystick (GameObject go)
	{
		Vector2 touchPos = UIEventListener.pointerEventData.position;
		touchPos -= new Vector2(91,91);
		joystick.transform.localPosition = touchPos;
	}

	void OnUpJoystick (GameObject go)
	{
		joystick.transform.localPosition = Vector2.zero;
		v=0;
		h=0;
	}

	void OnDragJoystick (GameObject go)
	{
		Vector2 touchPos = UIEventListener.pointerEventData.position;
		touchPos -= new Vector2(91,91);
		float distance = Vector2.Distance(Vector2.zero,touchPos);
		if(distance>73)
		{
			touchPos = touchPos.normalized*73;
		}
		joystick.transform.localPosition = touchPos;
		v = touchPos.y/73;
		h = touchPos.x/73;
	}
}
