using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    public GameObject plane;
    public GameObject player;
    public GameObject puerta1;
    public GameObject puerta2;
    public GameObject puerta3;
    public GameObject puerta4;
    public float speed = 1;
    private Rigidbody rb;    
    private float movementX;
    private float movementY;
    private float movementZ;

    private int coinCount;

    // Start is called before the first frame update
    void Start()
    {
        // instanciando el objeto que contiene este script
        // la bola
        rb = GetComponent<Rigidbody>();
        Debug.Log("Estoy en Start");
    }

    /**
     *  Evento Input System
     **/
    
    private void OnMove(InputValue movementValue)
    {
        plane.SetActive(true);
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
        // mensaje para la consola del Unity
        Debug.Log("Estoy en OnMove x: " + movementX);
    }

    private void FixedUpdate()
    {
        
        // para el teclado
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement * speed);

        // recogemos los datos del acelerometro
        Vector3 dir = Vector3.zero;
        dir.x = -Input.acceleration.y;
        dir.z = Input.acceleration.x;
        if (dir.sqrMagnitude > 1)
            dir.Normalize();
        
        dir *= Time.deltaTime;
        transform.Translate(dir * speed);
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Capsula"))            
        {
            coinCount++;
            Debug.Log("Score: " + coinCount);
            other.gameObject.SetActive(false);
        }

        if(coinCount == 2){
            puerta1.SetActive(false);
        }

        if(coinCount == 5){
            puerta2.SetActive(false);
        }

        if(coinCount == 8){
            puerta3.SetActive(false);
            puerta4.SetActive(false);
        }
        
        if (other.gameObject.CompareTag("Respawn")){
            player.transform.position = new Vector3(0,4.48f,-24.98f);
        }

    }

}
