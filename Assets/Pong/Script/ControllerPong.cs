using System;
using System.Collections;
using System.Collections.Generic;
using Pong.Script.Message;
using Pong.Script.PlayersAndGoal;
using Pong.Script.Struct;
using UnityEngine;

namespace Pong.Script
{
    public class ControllerPong : MonoBehaviour
    {
        [SerializeField] private StructGamePong GamePong;
        private MessageHander _messageHander;
        private bool gameInProgress = false;

        public void lunchGame()
        {
            gameInProgress = true;

            StartCoroutine(timerStart());
        }

        private int timer = 0;

        IEnumerator timerStart()
        {
            timer = timer + 1;
            Debug.Log(timer);
            yield return new WaitForSeconds(1);
            if (timer <= 3)
            {
                StartCoroutine(timerStart());
            }
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
            VictoryPrint(mesg);
            Time.timeScale = 0;
        }

        public void VictoryPrint(string mesg)
        {
            this.GamePong.MessageInfo.text = mesg;
            this.GamePong.MessageInfo.gameObject.SetActive(true);
        }
    }
}