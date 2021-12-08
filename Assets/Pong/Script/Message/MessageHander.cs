using System;
using Pong.Script.PlayersAndGoal;
using UnityEngine;
using UnityEngine.UI;

namespace Pong.Script.Message
{
    [Serializable]
    public class MessageHander
    {
        public string VictoryMesg(Player player)
        {
            var message = player.Pseudo + " Gagne !";
            return message;
        }
    }
}