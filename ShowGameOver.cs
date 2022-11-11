using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowGameOver : MonoBehaviour
{
    public GameObject player;
    public GameObject mainCanvas;
    public GameObject GameOverCanvas;
    private Health healthPlayer;
    public enum GameStates { Playing, GameOver }
    public GameStates GameState = GameStates.Playing;

    // Start is called before the first frame update
    void Start()
    {
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }
        if (mainCanvas == null)
        {
            mainCanvas = GameObject.FindGameObjectWithTag("Points");
        }
        if (GameOverCanvas == null)
        {
            GameOverCanvas = GameObject.FindGameObjectWithTag("GameOver");
        }
        GameOverCanvas.SetActive(false);
        healthPlayer = player.GetComponent<Health>();

    }
    // Update is called once per frame
    void Update()
    {
        //gameObject.GetComponent<Health>().isAlive = false;
        if (GameState == GameStates.Playing)
        {
            if (!healthPlayer.isAlive)
            {
                GameState = GameStates.GameOver;
                mainCanvas.SetActive(false);
                GameOverCanvas.SetActive(true);
            }

        }
    }
}
