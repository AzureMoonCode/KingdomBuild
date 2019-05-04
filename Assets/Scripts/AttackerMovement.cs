using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerMovement : MonoBehaviour {

    Transform location;
    AttackerManager charMan;
    float velocity;

    void Awake() {
        location = this.gameObject.transform;
        charMan = this.gameObject.GetComponent<AttackerManager>();
        velocity = charMan.Speed;
    }
    // Use this for initialization
    void Start () {
        charMan.isSelected = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (charMan.isSelected) {
            this.location.Translate(new Vector2(Input.GetAxisRaw("Horizontal")*velocity*Time.deltaTime, Input.GetAxisRaw("Vertical") * velocity * Time.deltaTime));
        }
	}
}
