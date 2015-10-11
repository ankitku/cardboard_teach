using UnityEngine;
using System.Collections;

public class AssignImage : MonoBehaviour {

	string url = "http://images.earthcam.com/ec_metros/ourcams/fridays.jpg";
	// Use this for initialization
	IEnumerator Start () {
		WWW www = new WWW(url);
		
		// wait until the download is done
		yield return www;
		
		// assign the downloaded image to the main texture of the object
		Renderer renderer = GetComponent<Renderer> ();
		renderer.material.mainTexture = www.texture;
	
	}
	
	// Update is called once per frame
	void Update () {

	}
}
