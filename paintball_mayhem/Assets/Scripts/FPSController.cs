using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FPSController : MonoBehaviour
{

    private GameObject player;
    public float playerSpeed = 10.0f;
    public float turnSpeed = 40.0f;

    public float jumpHeight = 1000.0f; // Adjust this value to control the jump height.
    public float jumpDuration = 2.0f; // Adjust this value to control how long the jump lasts.
    private float jumpTimer = 0.0f;

    public Rigidbody paintball;

    public GameObject paintballSpawn;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        Jump();
        ShootPaintballs();
    }


    public void MovePlayer()
    {
        float verticalMovement = Input.GetAxisRaw("Vertical") * playerSpeed * Time.deltaTime;
        float turnMovement = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;


        transform.Translate(Vector3.forward * verticalMovement);
        transform.Rotate(Vector3.up * turnMovement);

        //Debug.Log("Player is Moving!");
    }

    public void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            float jumpDistance = (jumpHeight * Time.deltaTime) / jumpDuration;
            transform.Translate(Vector3.up * jumpDistance);

            jumpTimer += Time.deltaTime;
        }
    }

    public void ShootPaintballs()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            Rigidbody paintballClone = Instantiate(paintball, paintballSpawn.transform.position, transform.rotation);
            paintballClone.velocity = transform.TransformDirection(Vector3.forward * 20);       
        }

    }

}
