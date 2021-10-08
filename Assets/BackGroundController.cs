using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundController : MonoBehaviour
{
    private float scrollSpeed = -1;
    private float deadLine = -16;
    private float startLine = 15.8f;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(this.scrollSpeed * Time.deltaTime, 0, 0);

        if (transform.position.x < this.deadLine)
        {
            transform.position = new Vector2(this.startLine, 0);
        }
    }
}