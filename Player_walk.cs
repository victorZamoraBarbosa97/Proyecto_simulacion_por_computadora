using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player_walk : MonoBehaviour
{
    public int playerSpeed;
    public int count;
    public Text countText;
    public string leve_Name;
    void Start()
    {
        count = 0;
        SetCountText();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            transform.position = transform.position + Camera.main.transform.forward * playerSpeed * Time.deltaTime;
        }
        if (count == 10)  // numero de abejas para pasar el nivel 
        {
            SceneManager.LoadScene(leve_Name);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("bees"))
        {
            Destroy(other.gameObject);
            count++;
            SetCountText();
        }
    }
    void SetCountText ()
    {
        countText.text = "Puntos: " + count.ToString(); // imprimir contador en pantalla
    }
}
