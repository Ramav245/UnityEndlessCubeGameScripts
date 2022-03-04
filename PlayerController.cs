using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{



    public Rigidbody rb; 
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0,0,0);







    }


    void Update()
    {
        StartCoroutine(startGame());
    }

    IEnumerator startGame()
    {
        yield return new WaitForSeconds(5);




        if (Input.GetKey("right"))
        {
            rb.velocity = new Vector3(10,0,25f);
        }
        else if(Input.GetKey("left"))
        {
            rb.velocity = new Vector3(-10,0,25f);
        }
        else
        {
            rb.velocity = new Vector3(0f,0,25f);
        }

    }









}
