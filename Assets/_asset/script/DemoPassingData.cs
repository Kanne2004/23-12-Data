using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoPassingData : MonoBehaviour
{
    public static int score = 10;
    public int coin;
    public DemoScriptableObject scriptableObjectData;

    private void Start()
    {
        coin = 1;
        Debug.Log($"coin: {coin}");
        Debug.Log($"score: {score}");
        score += 1;
        coin += 1;
        scriptableObjectData.crystal = 10;

        Debug.Log($"coin: {coin}");
        Debug.Log($"score: {score}");
        Debug.Log($"crystal: {scriptableObjectData.crystal}");
    }
}
