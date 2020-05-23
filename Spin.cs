using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    float spinValue = 90;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * spinValue * Time.deltaTime);
        
    }

    public void flipspin()
    {
        spinValue = -spinValue;
    }
}
  