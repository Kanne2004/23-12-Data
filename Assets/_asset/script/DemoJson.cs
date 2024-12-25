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
        demoVectorString = string.IsNullOrEmpty(demoVectorString)? JsonUtility.ToJson(Vector3.zero) : demoVectorString;

        demoVector = JsonUtility.FromJson<Vector3>(demoVectorString);
    }
}
