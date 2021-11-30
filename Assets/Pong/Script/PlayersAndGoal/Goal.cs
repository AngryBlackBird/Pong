using UnityEngine;

namespace Pong.Script.PlayersAndGoal
{
    public class Goal : MonoBehaviour
    {
        public bool hit = false;
        
        private void OnTriggerEnter2D(Collider2D other)
        {
            hit = true;
        }
    }
}