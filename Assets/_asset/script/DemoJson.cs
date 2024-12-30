using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DemoJson : MonoBehaviour
{
    public Vector3 demoVector;
    public string demoVectorString;
    private const string VECTOR_KEY = "VECTOR_KEY";

    [ContextMenu("Save Vector")]
    public void SaveVector()
    {
        demoVectorString = JsonUtility.ToJson(demoVector);
        PlayerPrefs.SetString(VECTOR_KEY, demoVectorString);
        PlayerPrefs.Save();
    }

    [ContextMenu("Load Vector")]
    public void LoadStar()
    {
        demoVectorString = PlayerPrefs.GetString(VECTOR_KEY, string.Empty);
        demoVectorString = string.IsNullOrEmpty(demoVectorString) ? JsonUtility.ToJson(Vector3.zero) : demoVectorString;

        demoVector = JsonUtility.FromJson<Vector3>(demoVectorString);
    }
    


    public GameData gameData;
    public string demoGameDataString;
    private const string GAME_DATA_KEY = "GAME_DATA_KEY";

    [ContextMenu("Save Data")]
    public void SaveData()
    {
        gameData.firstPlay = DateTime.Now.ToString("dd-MM-yyyy|HH:mm:ss");
        demoGameDataString = JsonUtility.ToJson(gameData);
        PlayerPrefs.SetString(GAME_DATA_KEY, demoGameDataString);
        PlayerPrefs.Save();
    }

    [ContextMenu("Load Data")]
    public void LoadData()
    {
        demoGameDataString = PlayerPrefs.GetString(GAME_DATA_KEY, string.Empty);
        demoGameDataString = string.IsNullOrEmpty(demoGameDataString) ? JsonUtility.ToJson(gameData) : demoGameDataString;

        gameData = JsonUtility.FromJson<GameData>(demoGameDataString);
    }
}
[Serializable]
public class GameData
{

    public int gold;
    public UserInfo userinfo;
    public string firstPlay;
    public string version;
    public List<Session> sessions;

}
[Serializable]
public class Session
{
    public DateTime startTime;
    public DateTime endTime;
    public List<int> scores;
}
[Serializable]
public class UserInfo
{
    public int age;
    public string userinfo;
    public DateTime dateOfBirth;
    public Sex sex;
}
public enum Sex
{
    Male, Female
}
