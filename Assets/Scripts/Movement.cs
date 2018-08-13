using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    [SerializeField] private float velocity;

    private Vector2 destination;
    private Vector2 destVec;

    bool hasTarget;

	// Use this for initialization
	void Start () {
        destination = new Vector2(0.0f, 0.0f);
        hasTarget = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (hasTarget) {
            destVec = destination - new Vector2(this.gameObject.transform.position.x, this.gameObject.transform.position.y);
        }
	}

}
