using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTargetPosition : MonoBehaviour {


    public GameObject target;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.localPosition = new Vector3(target.transform.localPosition.x,
                                              target.transform.localPosition.y,
                                              target.transform.localPosition.z);

	}
}
