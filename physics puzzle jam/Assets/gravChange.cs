using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gravChange : MonoBehaviour {

	public float gravNum;

	public TextMesh gravText;

	public bool gravTog;

	// Use this for initialization
	void Start () {
		//gravTog = false;
	}
	
	// Update is called once per frame
	void Update () {
		gravText.text = ("Gravity: " + gravNum);

		gravNum = this.GetComponent<scaleChange> ().scaleNum;


		if (this.GetComponent<scaleChange> ().scaleNum < 0.3f) {
			gravNum = 0;

		}

		this.GetComponent<Rigidbody2D> ().gravityScale = gravNum;



		if(Input.GetKeyDown(KeyCode.R)){
			SceneManager.LoadScene(0);
		}


		//if (Input.GetKeyDown (KeyCode.G)) {

			//if (gravTog == true) {				

				//gravTog = false;
			//}

			//else if (gravTog == false) {

				//gravTog = true;
			//}
		//}

		//if (gravTog == true) {
			//this.GetComponent<Rigidbody2D> ().gravityScale = 1;
			//gravText.text = "Gravity: On";
		//}

		//if (gravTog == false) {
			//this.GetComponent<Rigidbody2D> ().gravityScale = 0;
			//gravText.text = "Gravity: Off";
		//}

	}
}
