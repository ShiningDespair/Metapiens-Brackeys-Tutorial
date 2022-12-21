using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCollison : MonoBehaviour
{
    public GameManager gameManager;
    public PlayerControls playerControls;   


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Obstacle") { 
        playerControls.enabled = false;
        FindObjectOfType<GameManager>().EndGame();
        }
    }
}
