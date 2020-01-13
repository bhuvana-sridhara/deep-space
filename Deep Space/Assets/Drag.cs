using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    private bool selected;
    // Start is called before the first frame update
    void Update()
    {
        if(selected == true)
        {
            Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector2(cursorPos.x, cursorPos.y);
        }
        if(Input.GetMouseButtonUp(0))
        {
            selected = false;
        }
    }

    // Update is called once per frame
    void OnMouseOver()
    {
        if(Input.GetMouseButton(0))
        {
            selected = true; 
        }
    }
}
