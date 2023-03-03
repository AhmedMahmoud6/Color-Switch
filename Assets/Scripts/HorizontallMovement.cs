using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class HorizontallMovement : MonoBehaviour
{
    public float speed = 100f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime,0f,0f);
    }
}
