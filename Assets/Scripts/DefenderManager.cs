using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderManager : CharacterManager {

    private DefenderMovement defMove;

    private void Awake(){

        defMove = this.gameObject.GetComponent<DefenderMovement>();
    }
    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
