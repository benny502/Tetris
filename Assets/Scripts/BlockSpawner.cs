using UnityEngine;
using System.Collections;

public class BlockSpawner : MonoBehaviour {
	public GameObject[] blocks;

	// Use this for initialization
	void Start () {
		createBlock ();
	}
	
	// Update is called once per frame
	void Update () {
		if (GameLogic.create) {
			createBlock();
			GameLogic.create = false;
		}
	}
	

	public void createBlock(){
		Debug.Log ("ok");
		Instantiate (blocks[Random.Range(0, blocks.Length)],transform.position,transform.rotation);
	}
}
