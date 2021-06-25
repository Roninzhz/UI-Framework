using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeGamText : MonoBehaviour {

	 public Button btn;

	//声明一个Canvas
	Canvas cavs;
	// Use this for initialization
	void Start () {

		//获取父亲画布
		cavs = GetComponentInParent <Canvas>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ChangeBtnText()
    {
		//设置禁用
		cavs.enabled = false;
    }

	public void LoadChange_0()
	{
		SceneManager.LoadScene(0);
	}

	//跳转场景
	public void LoadChange()
	{
		SceneManager.LoadScene(1);
	}

}
