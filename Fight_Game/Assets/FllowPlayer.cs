using UnityEngine;
using System.Collections;

public class FllowPlayer : MonoBehaviour {

	private Transform player;
	public int speed;

	void Awake()
	{
		player = GameObject.FindGameObjectWithTag("Player").transform;
	}

	void Update()
	{
		Vector3 targetPos = player.position+ new Vector3(0,2.42f,-2.8f);
		transform.position = Vector3.Lerp(transform.position,targetPos,speed*Time.deltaTime);
		Quaternion targetRotation = Quaternion.LookRotation(player.position-transform.position);
		transform.rotation = Quaternion.Slerp(transform.rotation,targetRotation,speed*Time.deltaTime);
	}
}
