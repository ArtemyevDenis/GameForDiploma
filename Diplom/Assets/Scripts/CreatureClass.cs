using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game{
    abstract class Creature{
        public int health;
        public int speed;
        public int damage;
        public int status;
        public abstract void Move(float horizontal, float vertical, float turnSmoothTime, float turnSmoothVelocity, Transform cam);

    }
}