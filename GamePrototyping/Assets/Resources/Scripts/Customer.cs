using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Customer : MonoBehaviour {

	public static ServingDish dish;
	public static Text commentText;

	// Use this for initialization
	void Start () {
		// ServingDishとどちらが先にStartするかわからないので、シーンにCustomerを配置しないこと
		dish.customer = this;
	}

	// Update is called once per frame
	void Update () {

	}

	// 食品を受け取って評価する
	public void TakeFood(FoodProperty property){
		if(this.GetComponent<FoodRequirement>().canAcceptFood(property)) {
			commentText.text = property.GetName() + "　うん、おいしい！";
			Destroy(gameObject);
		} else {
			commentText.text = property.GetName() + "　なにこれ？";
		}
	}
}
