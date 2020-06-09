using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SimpleMoveCube : MonoBehaviour
{
    private float speed = 4;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(Vector3.forward + Vector3.right * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            transform.localScale = Vector3.one * 8;
        }
    }
}
