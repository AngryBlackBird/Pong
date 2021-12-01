using UnityEngine;

namespace Pong.Script.Ball
{
    public class Ball : MonoBehaviour
    {
        public Rigidbody2D Rigidbody2D;

        public Vector2 addlvlForce;
        
        public void addingForce()
        {
            Rigidbody2D.AddForce(addlvlForce);
        }
    }
}