using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodReqDebu : FoodRequirement {

	// Use this for initialization
	override protected void Start () {
		base.Start();
	}

	// Update is called once per frame
	void Update () {

	}

	override public bool canAcceptFood(FoodProperty property) {
		if(property.GetPropertyBool(FoodProperty.PropertyBool.Vegetables) == true && property.GetProperty(FoodProperty.Property.Greasiness) >= 5) {
			return true;
		}
		return false;
	}
}
