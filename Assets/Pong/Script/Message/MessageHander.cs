using System;
using Pong.Script.PlayersAndGoal;
using UnityEngine;
using UnityEngine.UI;

namespace Pong.Script.Message
{
    
 
    public class MessageHander
    {
        public string VictoryMesg(Player player)
        {
            var message = player.Pseudo + " Gagne !";
            return message;
        }
    }
}