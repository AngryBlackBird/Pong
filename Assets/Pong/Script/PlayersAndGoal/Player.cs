using UnityEngine;
using UnityEngine.UI;

namespace Pong.Script.PlayersAndGoal
{
    public class Player : MonoBehaviour
    {
        public int speedMove;

        public string Pseudo;

        public int PlayerScore;

        public Text pseudoUi;

        public Text playerScoreUi;

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

        public void setPseudo(string pseudoValue)
        {
            Pseudo = pseudoValue;
            pseudoUi.text = pseudoValue;
        }

        public void setPlayerScrore(int score)
        {
            PlayerScore = PlayerScore + score;
            playerScoreUi.text = PlayerScore.ToString();
        }
    }
}