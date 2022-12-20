using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCollison : MonoBehaviour
{
    public PlayerControls playerControls;   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Obstacle") { 
        playerControls.enabled = false; 
        }
    }
}
