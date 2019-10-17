using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;
using UnityEngine.UI;
/*
public class PlaySer : MonoBehaviour
{
    public string leaderboard;

    public static PlaySer instance;

    private void Awake()
    {
        instance = this;
        DontDestroyOnLoad(gameObject);
    }

     void Start()
    {
        PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder().Build();

        PlayGamesPlatform.InitializeInstance(config);
        PlayGamesPlatform.DebugLogEnabled = true;
        PlayGamesPlatform.Activate();
        SignIn();

    }
     private void SignIn()
    {
        Social.localUser.Authenticate(success =>
        {
        });
    }




    /// <summary>
    /// make login and manage the succes or failure
    /// </summary>
    public void login()
    {
        Social.localUser.Authenticate((bool success) =>
        {
            if (success)
            {
                Debug.Log("login sucess");
            }
            else
            {
                Debug.Log("login failed");
            }
        });
    }
}
*/