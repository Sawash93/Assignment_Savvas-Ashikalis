using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Body : MonoBehaviour
{
    Rigidbody2D playerHead;
    Rigidbody2D myBody;
    [SerializeField] float mySpeed = 2f;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        Follow();
    }

    private void Follow()
    {
        playerHead = FindObjectOfType<player>().GetComponent<Rigidbody2D>();
        myBody = GetComponent<Rigidbody2D>(); //not needed
        transform.LookAt(playerHead.position); //looking at snakehead
        transform.Translate(0.0f, 0.0f, mySpeed * Time.deltaTime); //following
    }
}
