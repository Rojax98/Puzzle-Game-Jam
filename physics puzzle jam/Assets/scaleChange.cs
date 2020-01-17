using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scaleChange : MonoBehaviour {

	public float scaleNum = 0.5f;
	Rigidbody2D body2D;
	public float maxScale;
	public bool hit;

	// Use this for initialization
	void Start () {

		scaleNum = 0.2f;

		body2D = GetComponent<Rigidbody2D> ();

	}
	
	// Update is called once per frame
	void Update () {

		if (scaleNum < 0.1f) {
			scaleNum = 0.1f;

		}
		if (scaleNum > 1f) {


			scaleNum = 1f;

		}

		

		var S = Input.GetAxis ("Mouse ScrollWheel");

		//print (S);

		body2D.transform.localScale = new Vector3 (scaleNum, scaleNum, 0);


		if (S < 0f) {

			scaleNum -= 0.1f;

		}
			



		if (S > 0f) {

			scaleNum += 0.1f;

		}



	}
		
}

