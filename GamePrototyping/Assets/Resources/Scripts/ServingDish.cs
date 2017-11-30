using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/*
 * お客さんに食品を出すためのお皿（と食材テーブル）
 */
public class ServingDish : MonoBehaviour {

	[SerializeField] private GameObject[] preparationFoods;
	[SerializeField] private float prepXstart, prepYstart, prepZstart;
	[SerializeField] private float prepXinterval, prepYinterval, prepZinterval;
	[SerializeField] private GameObject[] customerPrefabs;
	[System.NonSerialized] public GameObject food;
	public Customer customer = null;
	// Use this for initialization
	void Start () {
		Customer.dish = this;
		Customer.commentText = GameObject.Find("CustomerMessage").GetComponent<Text>();
		CallNewCustomer();
		Prepare();
	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter(Collision collision) {
		food = collision.gameObject;
	}

	// 最後にお皿に乗った食材を提供する（プロパティを渡す）
	public void Serve() {
		if(food == null){
			return;
		}
		FoodProperty property = food.GetComponent<FoodProperty>();
		customer.TakeFood(property);
		food = null;
		return;
	}

	// テーブルの上のものを片づけて食材を用意し直す
	public void Prepare() {
		GameObject[] tagobjs = GameObject.FindGameObjectsWithTag("Food");
		foreach (GameObject obj in tagobjs) {
			if(obj != null){
    		Destroy (obj);
			}
		}
		for(int i = 0; i < preparationFoods.Length; ++i){
			Instantiate(preparationFoods[i], new Vector3(	prepXstart + prepXinterval * i,
																										prepYstart + prepYinterval * i,
																										prepZstart + prepZinterval * i), preparationFoods[i].transform.rotation);
		}
		return;
	}

	// 新しい客を呼ぶ
	public void CallNewCustomer() {
		Prepare();
		int num = Random.Range(0, customerPrefabs.Length);
		if(customer == null) {

			customer = Instantiate(customerPrefabs[num]).GetComponent<Customer>();
		}
	}
}
