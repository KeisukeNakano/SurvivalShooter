using UnityEngine;
using System.Collections;

public class TestButtonClick : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	public void ClickTest () {
		Debug.Log ("Click");
		Application.LoadLevel("Level 01");
	}

	// Update is called once per frame
	void Update () {
	
	}
}
