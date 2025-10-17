using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// LINK TIL VIDEO
// https://www.youtube.com/watch?v=gtSUjPY2upE

public class CrosshairCursor : MonoBehaviour
{
    private bool GameStart;
    public Camera cam;

    void Start()
    {
        //cam = Camera.main;
        cam = cam.GetComponent<Camera>();
    }

    public void GameStarted()
    {
        Cursor.visible = false;
        GameStart = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(GameStart == true)
        {
            Vector2 mouseCursorPos = cam.ScreenToWorldPoint(Input.mousePosition);
            transform.position = mouseCursorPos;
        }
        
    }
}
