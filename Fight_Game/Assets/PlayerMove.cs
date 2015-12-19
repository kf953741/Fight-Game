using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {
	private CharacterController cc;
	public int moveSpeed =4;
	// Use this for initialization
	void Start () {
	
		cc = gameObject.GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");
		if(Mathf.Abs(h)>0.01||Mathf.Abs(v)>0.01)
		{
			Vector3 targetPos =new Vector3(h,0,v);
			transform.LookAt(targetPos+transform.position);
			cc.SimpleMove(transform.forward*moveSpeed);
		}
		
	}
}
