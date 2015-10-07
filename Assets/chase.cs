  using UnityEngine;
using System.Collections;

public class chase : MonoBehaviour {

	public Transform target;//oikakeru taishou - inspector kara touroku
	public float speed = 0.1f;//idou speed
	private Vector3 vec;


	// Use this for initialization
	void Start () {
//		target = GameObject.Find("escapeB").transform; 
	}
	
	// Update is called once per frame
	void Update () {
//		transform.rotation = Quaternion.LookRotation (target.position - transform.position);
		transform.rotation = Quaternion.Slerp (transform.rotation, Quaternion.LookRotation (target.position - transform.position), 0.3f);
		transform.position += transform.forward * speed;
	}
}
