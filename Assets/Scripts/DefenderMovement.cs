using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderMovement : MonoBehaviour {

    private DefenderManager defMan;

    [SerializeField] private Transform startingPoint;   

    [SerializeField] private bool isPlaced;
    public bool IsPlaced { get { return isPlaced; } }

    void Awake() {
        defMan = this.gameObject.GetComponent<DefenderManager>();
    }

    // Use this for initialization
    void Start () {
        defMan.isSelected = true;
	}
	
	// Update is called once per frame
	void Update () {
        Emplace();
	}

    public void Emplace() {
        if (defMan.isSelected)
        {
            if (!isPlaced)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    this.gameObject.transform.position = Input.mousePosition;
                    isPlaced = true;
                }
            }
        }
    }

    public void Dispel() {
        if (isPlaced)
        {
            this.gameObject.transform.position = startingPoint.position;
            isPlaced = false;
        }
    }
}
