using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodRequirement : MonoBehaviour {

	public string comment;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	private void Comment() {
		Customer.commentText.text += ("\n" + comment);
	}

	public bool canAcceptFood(FoodProperty property){
		return false;
	}
}
