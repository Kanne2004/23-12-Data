using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void loadSence2()
    {
        SceneManager.LoadScene("Scene2");
    }

    public void loadSence1()
    {
        SceneManager.LoadScene("Scene1");
    }
}
