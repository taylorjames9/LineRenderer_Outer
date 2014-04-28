using UnityEngine;
using System.Collections;

public class TappyScript : MonoBehaviour {

	public GameObject destinationSphere;

	void OnTap( TapGesture gesture ) 
	{ 

				//destinationSphere.transform.position = new Vector3 (gesture.Position.x, gesture.Position.y, 0);
				destinationSphere.transform.position = GetWorldPos( gesture.Position );
				print ("tap Position = " + gesture.Position);

	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

		public static Vector3 GetWorldPos( Vector2 screenPos )
		{
				Ray ray = Camera.main.ScreenPointToRay( screenPos );

				// we solve for intersection with z = 0 plane
				float t = -ray.origin.z / ray.direction.z;

				return ray.GetPoint( t );
		}
}
