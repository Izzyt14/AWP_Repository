using UnityEngine;
using System.Collections;
public class LineDrawer2 : MonoBehaviour 
{
    private LineRenderer line; // Reference to LineRenderer
    private Vector3 mousePos;    
    private Vector3 startPos;    // Start position of line
    private Vector3 endPos;    // End position of line
    BoxCollider2D bc;
    void Update () 
    {
        // On mouse down new line will be created 
        if(Input.GetMouseButtonDown(0))
        {
            if(line == null)
                createLine();
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0;
            line.SetPosition(0,mousePos);
            startPos = mousePos;
        }
        else if(Input.GetMouseButtonUp(0))
        {
            if(line)
            {
                mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mousePos.z = 0;
                line.SetPosition(1,mousePos);
                endPos = mousePos;
                addColliderToLine();
                line = null;
            }
        }
        else if(Input.GetMouseButton(0))
        {
            if(line)
            {
                mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mousePos.z = 0;
                line.SetPosition(1,mousePos);
            }
        }
    }
    // Following method creates line runtime using Line Renderer component
    private void createLine()
    {
        line = new GameObject("Line").AddComponent<LineRenderer>();
        line.material =  new Material(Shader.Find("Diffuse"));
        line.positionCount = 2;
        line.startWidth = 0.1f;
        line.endWidth = 0.1f;
        line.startColor = Color.black;
        line.endColor = Color.black;
        line.useWorldSpace = true;    
    }
    // Following method adds collider to created line
    private void addColliderToLine()
    {
        BoxCollider2D bc = new GameObject("Collider").AddComponent<BoxCollider2D>();
        //BoxCollider col = new GameObject("Collider").AddComponent<BoxCollider>();
        bc.transform.parent = line.transform;
        //col.transform.parent = line.transform; // Collider is added as child object of line
        float lineLength = Vector3.Distance (startPos, endPos); // length of line
        bc.size = new Vector3 (lineLength, 0.1f, 1f); // size of collider is set where X is length of line, Y is width of line, Z will be set as per requirement
        Vector3 midPoint = (startPos + endPos)/2;
        bc.transform.position = midPoint; // setting position of collider object
        float angle = (Mathf.Abs (startPos.y - endPos.y) / Mathf.Abs (startPos.x - endPos.x));
        if((startPos.y<endPos.y && startPos.x>endPos.x) || (endPos.y<startPos.y && endPos.x>startPos.x))
        {
            angle*=-1;
        }
        angle = Mathf.Rad2Deg * Mathf.Atan (angle);
        bc.transform.Rotate (0, 0, angle);
    }

}