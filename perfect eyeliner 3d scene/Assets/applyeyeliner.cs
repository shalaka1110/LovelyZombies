using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class applyeyeliner : MonoBehaviour {
    int vertexCount = 0;
    bool mouseDown = false;
    LineRenderer line;
    // Use this for initialization
    private void Awake()
    {
        line = GetComponent<LineRenderer>();
    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	 if (Input.GetMouseButtonDown(0))
        {
            mouseDown = true;
        }	
     if (mouseDown)
        {
            line.positionCount=vertexCount+1;
            (Input.mousePosition);
        }
	}
}
