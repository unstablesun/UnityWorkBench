using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour 
{

	void Start () {
		
	}
	
	void Update () {
		
	}


	public void GotoMenuSceneB()
	{
		SceneStack.Instance.LoadScene("MenuSceneB");

	}

	public void PushOverlayB()
	{
		SceneStack.Instance.PushOverlayB();

	}

	public void PopOverlayB()
	{
		SceneStack.Instance.PopOverlayB();

	}
}
