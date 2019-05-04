using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderManager : CharacterManager {

    private DefenderMovement defMove;

    [SerializeField] private float dispelTime;
    [SerializeField] private float elapsedTime;

    private void Awake(){

        defMove = this.gameObject.GetComponent<DefenderMovement>();
    }
    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (defMove.IsPlaced) UpdateTimer();
	}

    void UpdateTimer() {
        if (elapsedTime < dispelTime) elapsedTime += Time.deltaTime;
        else Dispel();
    }

    public void Dispel() {
        defMove.Dispel();
        elapsedTime = 0;
    }

}
