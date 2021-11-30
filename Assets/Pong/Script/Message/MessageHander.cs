using System;
using Pong.Script.PlayersAndGoal;
using UnityEngine;
using UnityEngine.UI;

namespace Pong.Script.Message
{
    [Serializable]
    public struct MessageUi
    {
        public Text MessageInfo;
    }


    [Serializable]
    public class MessageHander
    {
        public string VictoryMesg(Player player)
        {
            var message = player.name + " Gagne !";
            return message;
        }
    }
}