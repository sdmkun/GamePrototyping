﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodReqHot : FoodRequirement {

	// Use this for initialization
	override protected void Start () {
		base.Start();
	}

	// Update is called once per frame
	void Update () {

	}

	override public bool canAcceptFood(FoodProperty property) {
		if(property.GetProperty(FoodProperty.Property.Warmth) >= 7) {
			return true;
		}
		return false;
	}
}
