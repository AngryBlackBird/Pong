using System;
using Pong.Script.Message;
using Pong.Script.PlayersAndGoal;
using UnityEngine;

namespace Pong.Script
{
    public class ControllerPong : MonoBehaviour
    {
        [SerializeField] private StructPlayer[] _structPlayer;
        [SerializeField] private MessageHander _messageHander;
        [SerializeField] private MessageUi _messageUi;

        private int PlayerOneScore = 0;
        private int PlayerTwoScore = 0;

        //  public Collider test; 
        public void Update()
        {
            if (Input.GetKey(KeyCode.Z))
            {
                _structPlayer[0].Player.moveUp();
            }

            if (Input.GetKey(KeyCode.S))
            {
                _structPlayer[0].Player.moveDown();
            }

            if (Input.GetKey("up"))
            {
                _structPlayer[1].Player.moveUp();
            }

            if (Input.GetKey("down"))
            {
                _structPlayer[1].Player.moveDown();
            }

            if (_structPlayer[0].Goal.hit == true)
            {
                _structPlayer[0].Goal.hit = false;
                playerGoal(_structPlayer[1].Player);
            }

            if (_structPlayer[1].Goal.hit == true)
            {
                _structPlayer[1].Goal.hit = false;
                playerGoal(_structPlayer[0].Player);
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
            _messageUi.MessageInfo.text = mesg;
            _messageUi.MessageInfo.gameObject.SetActive(true);
        }
        
    }
}