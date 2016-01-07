using UnityEngine;
using System.Collections;

public class BlockController : MonoBehaviour {
	public float dropdownSpeed = 0.01f;
	public bool isActive = true;
	private float timeInterval = 0;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 speed = rigidbody2D.velocity;
		timeInterval += 1 * Time.deltaTime;
		if (speed.y == 0 && timeInterval>0.02 && isActive == true) {
			isActive = false;
			GameLogic.create = true;
		}
	}

	void FixedUpdate(){
		if (isActive) {
			if(Input.GetKey(KeyCode.DownArrow)){
				rigidbody2D.AddForce(new Vector2(0f,-dropdownSpeed));
			}
			if (Input.GetKey (KeyCode.LeftArrow)) {
				rigidbody2D.AddForce(new Vector2(-0.001f,0f));		
			}
			if (Input.GetKey (KeyCode.RightArrow)) {
				rigidbody2D.AddForce(new Vector2(0.001f,0f));		
			}
			if (Input.GetKeyDown(KeyCode.UpArrow)){
				Vector3 currentAngel = gameObject.transform.rotation.eulerAngles;
				currentAngel.z += 90;
				gameObject.transform.rotation = Quaternion.Euler(currentAngel);
				Debug.Log(currentAngel);
			}
		}

	}
}
