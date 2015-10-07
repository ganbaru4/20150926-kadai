using UnityEngine;
using System.Collections;

public class createBall : MonoBehaviour {

	public GameObject obj;

	// Use this for initialization
	void Start () {
//		GameObject instance = (GameObject)Instantiate(obj);
//		instance.transform.position = gameObject.transform.position;
//		instance.transform.rotation = gameObject.transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButton("Jump")){//Input.GetMouseButtonDown(0)
			GameObject instance = (GameObject)Instantiate(obj);
			instance.transform.position = gameObject.transform.position;
			instance.transform.rotation = gameObject.transform.rotation;

		}
	}
}
