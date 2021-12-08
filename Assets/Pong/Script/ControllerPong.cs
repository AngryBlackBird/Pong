using System;
using System.Collections;
using System.Collections.Generic;
using Pong.Script.Message;
using Pong.Script.PlayersAndGoal;
using Pong.Script.Struct;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Pong.Script
{
    public class ControllerPong : MonoBehaviour
    {
        [SerializeField] public StructGamePong GamePong;
        [SerializeField] private MessageHander _messageHander;


        public void StartGame()
        {
            GamePong.Ball.addingForce(RandomUnitVector());
            Debug.Log("startGame");
        }

        private static Vector2 RandomUnitVector()
        {
            var random = Random.Range(5000, 4000);
           // Debug.Log(Mathf.Cos(random));
            //Debug.Log(Mathf.Sin(random));
            return new Vector2(Mathf.Cos(random) * 150, Mathf.Sin(random) * 40);
        }

        public void Update()
        {
            if (Input.GetKey(KeyCode.Z))
            {
                GamePong._structPlayer[0].Player.moveUp();
            }

            if (Input.GetKey(KeyCode.S))
            {
                GamePong._structPlayer[0].Player.moveDown();
            }

            if (Input.GetKey("up"))
            {
                GamePong._structPlayer[1].Player.moveUp();
            }

            if (Input.GetKey("down"))
            {
                GamePong._structPlayer[1].Player.moveDown();
            }

            if (GamePong._structPlayer[0].Goal.hit == true)
            {
              //  Debug.Log("ok");
                GamePong._structPlayer[0].Goal.hit = false;
                playerGoal(GamePong._structPlayer[1].Player);
            }

            if (GamePong._structPlayer[1].Goal.hit == true)
            {
                GamePong._structPlayer[1].Goal.hit = false;


                playerGoal(GamePong._structPlayer[0].Player);
            }
        }

        public void playerGoal(Player player)
        {
            var mesg = _messageHander.VictoryMesg(player);
            player.setPlayerScrore(1);
            VictoryPrint(mesg);
            Time.timeScale = 0;
        }

        public void VictoryPrint(string mesg)
        {
            this.GamePong.MessageInfo.text = mesg;
            this.GamePong.MessageInfo.gameObject.SetActive(true);
            GamePong.resetGame.gameObject.SetActive(true);
        }
    }
}