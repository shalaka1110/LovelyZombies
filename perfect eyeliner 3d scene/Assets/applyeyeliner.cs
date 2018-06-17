using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class applyeyeliner : MonoBehaviour
{
    int vertexCount;
    bool mouseDown = false;
    LineRenderer line;
    // Use this for initialization

    void Start()
    {
        line = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            mouseDown = true;
        }
        if (mouseDown)
        {
            line.positionCount = vertexCount + 1;
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 15f));
            line.SetPosition(vertexCount, mousePos);
            vertexCount++;
        }
        if (Input.GetMouseButtonUp(0))
        {
            mouseDown = false;
            vertexCount = 0;
            line.positionCount = 0;
        }
    }
}
