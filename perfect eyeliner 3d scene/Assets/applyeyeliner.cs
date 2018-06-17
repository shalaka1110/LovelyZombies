using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class applyeyeliner : MonoBehaviour
{
    int vertexCount = 0;
    bool mouseDown = false;
    LineRenderer line;
    // Use this for initialization

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        line = GetComponent<LineRenderer>();
        if (Input.GetMouseButtonDown(0))
        {
            mouseDown = true;
        }
        if (mouseDown)
        {
            line.positionCount = vertexCount + 1;
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
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
