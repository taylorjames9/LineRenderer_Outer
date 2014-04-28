using UnityEngine;
using System.Collections;

public class BackgroundManager : MonoBehaviour {


		public GameObject mileMarkerPrefab; 

	// Use this for initialization
	void Start () {


				for (int i = 0; i < 100; i ++) {
						GameObject clone;
						clone = Instantiate (mileMarkerPrefab, new Vector3 (i * 10, -3.5f, 0), Quaternion.identity) as GameObject;
				}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
