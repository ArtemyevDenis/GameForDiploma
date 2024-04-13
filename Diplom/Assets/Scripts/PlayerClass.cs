using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game{
    class Player : Creature{
        CharacterController body;
        public Player(int health, int speed, int damage, int status, CharacterController body){
            this.health = health;
            this.speed = speed;
            this.damage = damage;
            this.status = status;
            this.body = body;
        }

        public override void Move(float horizontal, float vertical, float turnSmoothTime, float turnSmoothVelocity, Transform cam){
            Vector3 direction = new Vector3(horizontal, 0, vertical).normalized;
            if(direction.magnitude >= 0.1f) {
                float targetAngle  = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y; 
                float angle = Mathf.SmoothDampAngle(this.body.transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
                this.body.transform.rotation = Quaternion.Euler(0f, angle, 0f);
                Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
                this.body.Move(moveDir.normalized * this.speed * Time.deltaTime); 
            }
        }

    }
}