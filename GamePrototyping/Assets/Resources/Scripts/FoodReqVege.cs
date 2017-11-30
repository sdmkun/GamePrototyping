using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodReqVege : FoodRequirement {

	// Use this for initialization
	override protected void Start () {
		base.Start();
	}

	// Update is called once per frame
	void Update () {

	}

	override public bool canAcceptFood(FoodProperty property) {
		if(property.GetPropertyBool(FoodProperty.PropertyBool.Vegetables) == true) {
			return true;
		}
		return false;
	}
}
