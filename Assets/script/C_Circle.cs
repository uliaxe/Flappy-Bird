using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_Circle : MonoBehaviour
{

    public float speed = 4.0f;
    public float jumpSpeed = 8.0f; // Vitesse de saut
    public float vitesseDeplacement = 3f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (rb == null)
        {
            rb = gameObject.AddComponent<Rigidbody>();
            rb.useGravity = true;
        }
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0.0f, verticalInput);

        // Mouvement horizontal (gauche/droite)
        rb.AddForce(new Vector3(horizontalInput, 0f, 0f) * speed);

        // Mouvement vertical (avant/arrière)
        rb.AddForce(new Vector3(0f, 0f, verticalInput) * speed);

        // Déplacement latéral en fonction des touches Q et D
        if (Input.GetKey(KeyCode.Q))
            rb.AddForce(Vector3.left * vitesseDeplacement);
        else if (Input.GetKey(KeyCode.D))
            rb.AddForce(Vector3.right * vitesseDeplacement);


        // Saut avec la barre d'espace
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Définit une vitesse verticale pour le saut
            rb.velocity = new Vector3(rb.velocity.x, jumpSpeed, rb.velocity.z);
        }
    }
}
