using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalInit : MonoBehaviour 
{
	bool FirstPass = true;

	void Start () 
	{
		
	}
	
	void Update () 
	{
		if (FirstPass == true) 
		{
			SceneStack.Instance.LoadScene ("BaseScene");
			FirstPass = false;
		}
		
	}
}
