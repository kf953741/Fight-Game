using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuController : MonoBehaviour {

	public Color purple;

	public SkinnedMeshRenderer headMesh;
	public SkinnedMeshRenderer handMesh;
	public SkinnedMeshRenderer[] bodyArray;
	public Mesh[] headMeshs;
	private int headMeshIndex=0;
	public Mesh[] handMeshs;

	private int handMeshIndex=0;

	private Button btnHeadChange;
	private GameObject btnHandChange;

	private Color[] colorArray;
	private int colorIndex = -1;

	void Awake()
	{

	}

	void Start()
	{
		btnHeadChange = GameObject.Find(@"head/btn_headChange").GetComponent<Button>();
		btnHandChange = GameObject.Find(@"hand/btn_handChange").gameObject;
		UIEventListener.Get(btnHandChange).onClick = OnHandMeshChange; 
		UIEventListener.Get(GameObject.Find(@"GameObject/btn_blue").gameObject).onClick = OnChangeBlue;
		UIEventListener.Get(GameObject.Find(@"GameObject/btn_red").gameObject).onClick = OnChangeRed;
		UIEventListener.Get(GameObject.Find(@"GameObject/btn_purple").gameObject).onClick = OnChangePurple;
		UIEventListener.Get(GameObject.Find(@"GameObject/btn_lightGreen").gameObject).onClick = OnChangeLightGreen;
		UIEventListener.Get(GameObject.Find(@"GameObject/btn_green").gameObject).onClick = OnChangeGreen;
		UIEventListener.Get(GameObject.Find(@"btn_play").gameObject).onClick = OnClickPlay;
		btnHeadChange.onClick.AddListener(OnHeadMeshChange);
		colorArray = new Color[]{Color.blue,Color.green,purple,Color.red,Color.cyan};
		DontDestroyOnLoad(gameObject);
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

	public void OnChangeBlue(GameObject go)
	{
		colorIndex = 0;
		OnChangeColor(Color.blue);
	}

	public void OnChangeGreen(GameObject go)
	{
		colorIndex = 1;
		OnChangeColor(Color.green);
	}

	public void OnChangePurple(GameObject go)
	{
		colorIndex = 2;
		OnChangeColor(purple);
	}

	public void OnChangeRed(GameObject go)
	{
		colorIndex = 3;
		OnChangeColor(Color.red);
	}

	public void OnChangeLightGreen(GameObject go)
	{
		colorIndex = 4;
		OnChangeColor(Color.cyan);
	}

	private void OnChangeColor(Color c)
	{
		foreach(SkinnedMeshRenderer mesh in bodyArray)
		{
			mesh.material.color = c;
		}
	}
	private void Save()
	{
		PlayerPrefs.SetInt("HeadMeshIndex",headMeshIndex);
		PlayerPrefs.SetInt("HandMeshIndex",handMeshIndex);
		PlayerPrefs.SetInt("ColorIndex",colorIndex);
	}
	public void OnClickPlay(GameObject go)
	{
		Save();
		Application.LoadLevel(1);
	}
}
