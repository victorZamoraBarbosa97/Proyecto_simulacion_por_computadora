using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerGrab : MonoBehaviour
{
    public GameObject ball;
    public GameObject MyHand;
    public float handpower;
    bool inHands = false;
    Collider ballCollid;
    Rigidbody ballrigid;
    Camera cam;



    // Start is called before the first frame update
    void Start()
    {
        ballCollid = ball.GetComponent<SphereCollider>();
        ballrigid = ball.GetComponent<Rigidbody>();
        cam = GetComponentInChildren<Camera>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            if (!inHands && MyHand.GetComponent<grab>().canGrab)
            {
                ballCollid.isTrigger = true;
                ball.transform.SetParent(MyHand.transform);
                ball.transform.localPosition = new Vector3(0f, -.55f, 0f);
                inHands = true;
                ballrigid.useGravity = false;  // quita la gravedad de la pelota
                ballrigid.velocity = Vector3.zero;  // quita la velocidad
            } 
            else if (inHands){
                ballCollid.isTrigger = false;
                ballrigid.useGravity = true;

                this.GetComponent<playerGrab>().enabled = false;
                ball.transform.SetParent(null);
                ballrigid.velocity = cam.transform.rotation * Vector3.forward * handpower;
                inHands = false;
            }
            
        }
        
    }
}
