using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneStack : Singleton<SceneStack> 
{
	public enum StackItemType
	{
		StackBaseScene = 0,
		StackOverlay
	};

	public struct StackItem
	{
		public StackItemType sceneType;
		public string sceneName;

		public StackItem(string name, StackItemType sit)
		{
			this.sceneName = name;
			this.sceneType = sit;
		}
	}

	public static Stack<StackItem> StackOfScenes = new Stack<StackItem>();



	void Start () 
	{

	}

	void Update () 
	{

	}

	public void LoadScene(string sceneName)
	{
		SceneManager.LoadScene (sceneName, LoadSceneMode.Single);
			
	}

	public void PushOverlayB()
	{
		SceneManager.LoadScene ("OverlayB", LoadSceneMode.Additive);

	}

	public void PopOverlayB()
	{
		SceneManager.UnloadSceneAsync ("OverlayB");

	}
}
