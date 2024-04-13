using System.Collections;
using System.Collections.Generic;
using Game;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController body_;
    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;
    public Transform cam;
    Player a;
    // Start is called before the first frame update
    void Start()
    {
        // body_ = GetComponent<Rigidbody>();
        a = new Player(100,12,100,1,body_);        
    }

    // Update is called once per frame
    void Update()
    {
        a.Move(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"),turnSmoothTime,turnSmoothVelocity,cam);        
    }
}
