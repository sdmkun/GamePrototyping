using UnityEngine;
using System.Collections;

public class GrappleObject : MonoBehaviour
{
	private Vector3 screenPoint;
	private Vector3 offset;
	Rigidbody rigidbody;

	void Start () {
		rigidbody = gameObject.GetComponent<Rigidbody>();
	}
	void OnMouseDown ()
	{
		// マウスカーソルは、スクリーン座標なので、
		// 対象のオブジェクトもスクリーン座標に変換してから計算する。

		// このオブジェクトの位置(transform.position)をスクリーン座標に変換。
		screenPoint = Camera.main.WorldToScreenPoint (transform.position);
		// ワールド座標上の、マウスカーソルと、対象の位置の差分。
		offset = transform.position - Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));

		rigidbody.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
	}

	void OnMouseUp() {
		rigidbody.constraints = RigidbodyConstraints.None;
	}

	void OnMouseDrag ()
	{
		Vector3 currentScreenPoint = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
		Vector3 currentPosition = Camera.main.ScreenToWorldPoint (currentScreenPoint) + this.offset;
		transform.position = currentPosition + new Vector3(0.0f, 1.0f, 0.0f);
	}
}
