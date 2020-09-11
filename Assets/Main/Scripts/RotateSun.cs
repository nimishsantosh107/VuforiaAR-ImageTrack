using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSun : MonoBehaviour
{
    public float x;
    public float y;
    public float z;
    Vector3 movement;
    // Start is called before the first frame update
    void Start()
    {
        movement = new Vector3(x,y,z);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(movement * Time.deltaTime);
    }
}
