using UnityEngine;
using System.Collections;

public class TappyScript : MonoBehaviour {

	public GameObject destinationSphere;

	void OnTap( TapGesture gesture ) 
	{ 

				destinationSphere.transform.position = new Vector3 (gesture.Position.x, gesture.Position.y, 0);
				print ("tap Position = " + gesture.Position);

	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
