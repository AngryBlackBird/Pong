using System;
using System.Collections;
using System.Collections.Generic;
using Pong.Script.Struct;
using UnityEngine;

namespace Pong.Script
{
    public class ControllerSession : MonoBehaviour
    {
        [SerializeField] private StructSession structSession;
        [SerializeField] private CanvasStruct canvasStruct;
        private int _timer = 0;

        public void Start()
        {
            Time.timeScale = 0;
        }

        public void StartSession()
        {
            if ((structSession.PanelStart.PlayerOne.text != String.Empty) &&
                (structSession.PanelStart.PlayerTwo.text != String.Empty))
            {
                LunchGame();
            }
            else
            {
                Debug.Log("ko");
            }
        }

        public void RebootParty()
        {
            _timer = 0;
            structSession.ControllerPong.GamePong.Ball.ResetBall();

            structSession.ControllerPong.GamePong.resetGame.gameObject.SetActive(false);
            LunchGame();
        }

        private void LunchGame()
        {
            structSession.ControllerPong.GamePong._structPlayer[0].Player
                .setPseudo(structSession.PanelStart.PlayerOne.text);
            structSession.ControllerPong.GamePong._structPlayer[1].Player
                .setPseudo(structSession.PanelStart.PlayerTwo.text);

            InitGame();
            Time.timeScale = 1;

            canvasStruct.sessionGame.SetActive(false);
            canvasStruct.pongGame.SetActive(true);

            StartCoroutine(TimerStart());
        }

        private void InitGame()
        {
            //structSession.ControllerPong.GamePong
        }


        private IEnumerator TimerStart()
        {
            _timer = _timer + 1;


            structSession.ControllerPong.GamePong.MessageInfo.text = (_timer - 1).ToString();
            if (_timer == 1)
            {
                structSession.ControllerPong.GamePong.MessageInfo.text = "Prêt ?";
            }

            if (_timer == 5)
            {
                structSession.ControllerPong.GamePong.MessageInfo.text = "GO ! ";
            }

            // Debug.Log(_timer);
            yield return new WaitForSeconds(1);
            if (_timer <= 4)
            {
                StartCoroutine(TimerStart());
            }
            else
            {
                structSession.ControllerPong.GamePong.MessageInfo.text = "";
                structSession.ControllerPong.StartGame();
            }
        }
    }
}