using UnityEngine;

namespace Pong.Script.PlayersAndGoal
{
    public class Player : MonoBehaviour
    {
        public int speedMove;

        public void moveUp()
        {
            gameObject.transform.position =
                gameObject.transform.position + new Vector3(0, speedMove * Time.deltaTime, 0);
        }

        public void moveDown()
        {
            gameObject.transform.position =
                gameObject.transform.position - new Vector3(0, speedMove * Time.deltaTime, 0);
        }
    }
}