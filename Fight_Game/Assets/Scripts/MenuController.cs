using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuController : MonoBehaviour {

	public Color purple;
	public SkinnedMeshRenderer headMesh;
	public SkinnedMeshRenderer handMesh;
	public Mesh[] headMeshs;
	private int headMeshIndex=0;
	public Mesh[] handMeshs;
	private int handMeshIndex=0;

	private Button btnHeadChange;
	private GameObject btnHandChange;
	void Awake()
	{

	}

	void Start()
	{
		btnHeadChange = GameObject.Find(@"head/btn_headChange").GetComponent<Button>();
		btnHandChange = GameObject.Find(@"hand/btn_handChange").gameObject;
		UIEventListener.Get(btnHandChange).onClick = OnHandMeshChange; 
		btnHeadChange.onClick.AddListener(OnHeadMeshChange);
	}
	public  void OnHeadMeshChange()
	{
		headMeshIndex++;
		headMeshIndex%=headMeshs.Length;
		headMesh.sharedMesh = headMeshs[headMeshIndex];
	}
	public void OnHandMeshChange(GameObject go)
	{
		handMeshIndex++;
		handMeshIndex%=handMeshs.Length;
		handMesh.sharedMesh = handMeshs[handMeshIndex];
	}
	public void OnChangeBlue()
	{
		OnChangeColor(Color.blue);
	}
	public void OnChangeGreen()
	{
		OnChangeColor(Color.green);
	}
	public void OnChangePurple()
	{
		OnChangeColor(purple);
	}
	public void OnChangeRed()
	{
		OnChangeColor(Color.red);
	}
	public void OnChangeLightGreen()
	{
		OnChangeColor(Color.cyan);
	}
	private void OnChangeColor(Color c)
	{

	}
	public void OnClickPlay()
	{

	}
}
