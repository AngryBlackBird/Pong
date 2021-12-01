using System;
using Pong.Script.Panel;
using Pong.Script.Struct;
using UnityEngine;

namespace Pong.Script
{
    public class ControllerSession : MonoBehaviour
    {
        [SerializeField] private StructSession _structSession;

        // Start is called before the first frame update

        public void StartingGame()
        {
            if ((_structSession.PanelStart.PlayerOne.text != String.Empty) &&
                (_structSession.PanelStart.PlayerTwo.text != String.Empty))
            {
                _structSession.ControllerPong.lunchGame();
            }
            else
            {
                Debug.Log("ko");
            }
        }
        // Update is called once per frame
    }
}