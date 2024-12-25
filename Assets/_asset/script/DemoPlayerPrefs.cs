using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoPlayerPrefs : MonoBehaviour
{
    public int star;

    public bool dung_sai;
    private int checkdungsai;

    public double _double;
    private string _stringdouble;

    public Vector2 _vector2;

    private const string STAR_KEY = "star";
    private const string DUNGSAI_KEY = "dung_sai";
    private const string DOUBLE_KEY = "_double";
    private const string X_KEY = "vectorX"; 
    private const string Y_KEY = "vectorY";

    [ContextMenu("Save Star")]
    public void SaveStar()
    {
        PlayerPrefs.SetInt(STAR_KEY, star);

        
        if (dung_sai == true)
            checkdungsai = 1;
        else
            checkdungsai = 0;

        PlayerPrefs.SetInt(DUNGSAI_KEY, checkdungsai);


        _stringdouble = _double.ToString();
        PlayerPrefs.SetString(DOUBLE_KEY, _stringdouble);


        PlayerPrefs.SetFloat(X_KEY, _vector2.x);
        PlayerPrefs.SetFloat(Y_KEY, _vector2.y);

        PlayerPrefs.Save();

    }

    [ContextMenu("Load Star")]
    public void LoadStar()
    {
        star = PlayerPrefs.GetInt(STAR_KEY, 0);


        checkdungsai = PlayerPrefs.GetInt(DUNGSAI_KEY, 0);
        if (checkdungsai == 1)
            dung_sai = true;
        else
            dung_sai = false;

        
       _stringdouble= PlayerPrefs.GetString(DOUBLE_KEY, "empty");
        _double = Convert.ToDouble(_stringdouble);


        _vector2.x = PlayerPrefs.GetFloat(X_KEY, 0);
        _vector2.y = PlayerPrefs.GetFloat(Y_KEY, 0);
    }
}
