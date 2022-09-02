using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbiter : MonoBehaviour
{
    float timeCounter = 0;
    [SerializeField] float speed = 5f;
    [SerializeField] float width = 4f;
    [SerializeField] float height = 7f;

    void Update()
    {
        timeCounter += Time.deltaTime * speed;
        float x = 0;
        float y = Mathf.Sin(timeCounter) * height;
        float z = Mathf.Cos(timeCounter) * width;

        transform.position = new Vector3(x, y, z);
    }
}
