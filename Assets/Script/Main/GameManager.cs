﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public int game_score = 0;
    public GameObject MainBackAni;
    public GameObject mainBGM;
	public GameObject Window;

    public static GameManager instance = null;

    // Use this for initialization
    void Start()
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
    }

    public void Update()
    {
        if (SceneManager.GetActiveScene().name.Equals("Main"))
        {
            if (Input.GetKeyDown(KeyCode.Escape))
			{
				Window.SetActive(true);
			}
        }
    }

	public void QuitApplication()
	{
		Application.Quit();
	}

	public void QuitWindow()
	{
		Window.SetActive(false);
	}

	public void PlayScene()
    {
        //AutoFade.LoadLevel("GamePlay", 0.5f, 0.5f, Color.black);
        SceneManager.LoadScene("Loading");
        //SceneManager.LoadScene("GamePlay");
        //Debug.Log("GamePlay");
    }

    public void CharacterSelect()
    {
        AutoFade.LoadLevel("Character", 1.5f, 0.5f, Color.black);
         //SceneManager.LoadScene("Character");
    }

	public void WeaponSelect()
	{
		SceneManager.LoadScene("Weapon");
        //UserConnect.instance._GetUser("TestUser");
    }

    public void CreditScene()
    {
        SceneManager.LoadScene("Credit");
    }

    public void Tutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }

    // 사운드 관련
    public void BGMSoundOn()
    {
        GameObject.Find("GlobalBGM").GetComponent<GlobalBGM>().BGMSoundOn();
    }

    public void BGMSoundOff()
    {
        GameObject.Find("GlobalBGM").GetComponent<GlobalBGM>().BGMSoundOff();
    }

    public void SFXSoundOn()
    {
        GameObject.Find("GlobalSFX").GetComponent<GlobalSFX>().SFXSoundOn();
    }

    public void SFXSoundOff()
    {
        GameObject.Find("GlobalSFX").GetComponent<GlobalSFX>().SFXSoundOff();
    }
}
