using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public float playerSpeed = 10f;
    public float playerSpeedHorizontal = 10f;
    public float horizontalInput;
    public float jumpForce = 10f;
    public Rigidbody playerRB;
    public int jumpCount = 2;
    public int jumpResetter;

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        jumpResetter = jumpCount;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.left * playerSpeed * Time.deltaTime);
        transform.Translate(Vector3.forward * playerSpeedHorizontal * Time.deltaTime* horizontalInput);

        if (Input.GetKeyDown(KeyCode.Space) && jumpCount >0)
        {
            playerRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            jumpCount--;
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Ground")
        {
            jumpCount = jumpResetter;
        }
       
    }
}
