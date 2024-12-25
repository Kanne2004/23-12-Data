using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class DemoFile : MonoBehaviour
{
    public int diamond;
    public string fileName;
    private static string filePath;

    [ContextMenu("Demonstrate")]

    private void Demonstrate()
    {
        filePath = Path.Combine(Application.persistentDataPath, fileName);
        Debug.Log($"data path: {filePath}");

        diamond = 10;
        Debug.Log($"diamond: {diamond}");
        SaveData();
    }

    private void SaveData()
    {
        File.WriteAllText(filePath, diamond.ToString());
    }
    public static string LoadData()
    {
        return File.ReadAllText(filePath);
    }
}
