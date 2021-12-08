using System;
using UnityEngine;

namespace Pong.Script.Ball
{
    public class Ball : MonoBehaviour
    {
        public Rigidbody2D Rigidbody2D;


        public void addingForce(Vector2 addlvlForce)
        {
            Rigidbody2D.AddForce(addlvlForce);
        }

        public void ResetBall()
        {
            gameObject.transform.position = new Vector3(0, 0, 0);
            Rigidbody2D.velocity = Vector2.zero;
          //  Rigidbody2D.angularVelocity = Single.NaN;
        }
    }
}