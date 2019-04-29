using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnlineInitializer : MonoBehaviour {

	public static int OnlinePlayers = 0;

	// Use this for initialization
	void Start () {
		OnlinePlayers = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(OnlinePlayers == 3){
			this.gameObject.SetActive(false);
		}
	}
}
