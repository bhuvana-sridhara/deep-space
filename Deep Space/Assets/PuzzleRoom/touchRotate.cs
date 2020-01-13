using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchRotate : MonoBehaviour
{
    // Start is called before the first frame update
    //private void OnMouseDown()
    //{
    //    if (!GameControl.youWin)
    //}
     void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(1))
        {
            transform.Rotate(0f, 0f, 90f);

        }
    }
}
