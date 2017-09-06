﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class ResultManager : MonoBehaviour
{
    public GameObject scoreText;
    public int score = 0;

    public static ResultManager instance = null;

    private void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            //잘못된 인스턴스를 가르키고 있을 경우
            Destroy(gameObject);
        }
        scoreText = GameObject.Find("Score");
    }

    public void ResultScore(int score_parm)
    {
        scoreText.GetComponent<Text>().text = score_parm.ToString();
       // scoreText = GameObject.Find("Score");
    }
}