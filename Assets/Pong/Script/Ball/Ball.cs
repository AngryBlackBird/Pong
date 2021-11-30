using UnityEngine;

namespace Pong.Script.Ball
{
    public class Ball : MonoBehaviour
    {
        public Rigidbody2D Rigidbody2D;

        public Vector2 addForce;

        public void Start()
        {
            Rigidbody2D.AddForce(addForce);
        }
    }
}