using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    Vector3 spin;
    void Update()
    {
        spin = new Vector3(0f, 4f, 4f);

        transform.Rotate(spin);
    }
}
