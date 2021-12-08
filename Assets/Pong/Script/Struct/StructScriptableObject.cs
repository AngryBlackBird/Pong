using System;
using Pong.Script.Message;
using Pong.Script.PlayersAndGoal;
using Pong.Script.Struct.Panel;
using UnityEngine;
using UnityEngine.UI;


namespace Pong.Script.Struct
{
    [Serializable]
    public struct StructSession
    {
        [SerializeField] public PanelStart PanelStart;
        public ControllerPong ControllerPong;
    }

    [Serializable]
    public struct StructGamePong
    {
        [SerializeField] public StructPlayer[] _structPlayer;
        public Ball.Ball Ball;
        public Text MessageInfo;
        public Button resetGame;
    }
}