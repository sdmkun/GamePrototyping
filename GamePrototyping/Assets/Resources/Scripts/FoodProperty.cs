using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodProperty : MonoBehaviour {

	// 列挙型で、食品の属性を表す配列の要素番号を定義　配列の中の数値(0-10)で属性を評価
	public enum Property {
		Warmth,			// 暖かさ：0が冷たく、10が温かい
		Saltiness,	// しょっぱさ：0がしょっぱくなく、10がしょっぱい
		Sweetness,	// 甘さ：0が甘くなく、10が甘い
		Greasiness,	// 油っこさ：0が油っこくなく、10が脂っこい
		EaseOfEat,	// 食べやすさ（食べるのに掛かる時間、こぼしにくさなど）：0が食べにくい、10が食べやすい
		TimePeriod,	// 食べるのに適した時間帯：0が朝寄り、10が夜寄り、5に近いとどちらでもない
		MAX					// 要素数
	};

	// 列挙型で、食品の属性を表すBool型配列の要素番号を定義　該当する属性にtrueが入る
	public enum PropertyBool {
		Oriental,		// 東洋風
		European,		// 西洋風
		Vegetables,	// 野菜
		Meat, 			// 肉
		Dessert,		// デザート（甘味）
		MAX					// 要素数
	};

	private int[] property = new int[(int)Property.MAX];
	private bool[] propertyBool = new bool[(int)PropertyBool.MAX];

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public int GetProperty(Property p){
		return property[(int)p];
	}

	public bool GetPropertyBool(PropertyBool p){
		return propertyBool[(int)p];
	}

}
