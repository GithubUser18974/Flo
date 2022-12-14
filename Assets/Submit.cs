using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
using System;
using UnityEngine.Networking;

public class Submit : MonoBehaviour
{
    public Text _Name;
    public Text phone;
    public Text email;
    public Text company;

    FileInfo f;
    public string path;
    void Start()
    {

        if (path == null || path == "" || path == " ")
        {
            path = Application.persistentDataPath + " / data.txt";
            f = new FileInfo(Application.persistentDataPath + " / data.txt");
        }
        else
        {
            path = "D:/" + " / data.txt";
            f = new FileInfo("D:/" + " / data.txt");
        }

    }

    public void Save(string name, string phone, string email, string copm)
    {
        StreamWriter w;
        if (!f.Exists)
        {
            w = f.CreateText();
        }
        else
        {
            w = new StreamWriter(path, true);
        }
        w.WriteLine(name);
        w.WriteLine(phone);
        w.WriteLine(email);
        w.WriteLine(copm);
        w.WriteLine("_______>-<_______");
        w.Close();
    }
    public void submit()
    {


        Invoke("AutoSubmit", 4);

    }
    public void AnimatePanel2()
    {

    }
    public void AutoSubmit()
    {


        Save(_Name.text, phone.text, email.text, company.text);

    }
    private void HandleUploadResult(string result)
    {
        Debug.Log(result);
    }

    public void restart()
    {
     
    }
}