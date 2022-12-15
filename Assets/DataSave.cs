using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DataSave : MonoBehaviour
{
    public string names, phone, gender, age;
    public TMP_InputField nameInp, phoneInp, genderInp, ageInp;
    public GameObject OnScreenKeyboard;
    public Text T1, T2;
   // public KeyboardScript keyboard;
    public void SetKeboard(TMP_InputField tt)
    {
          //  T1.text = string.Empty;
       // T2.text = string.Empty;
       // keyboard.TextField = tt;
        T1.text = tt.text;
        T2.text = tt.text;

    }
    public void SetName( )
    {
        names = nameInp.text;
        T1.text= nameInp.text;
        T2.text= nameInp.text;

    }
    public void SetPhone()
    {
        phone = phoneInp.text;
        T1.text = phoneInp.text;
        T2.text = phoneInp.text;
    }
    public void SetGender()
    {
        gender = genderInp.text;
        T1.text = genderInp.text;
        T2.text = genderInp.text;
    }
    public void SetAge()
    {
        age = ageInp.text;
        T1.text = ageInp.text;
        T2.text = ageInp.text;
    }
    public void NextButton()
    {
        if (phone.Length != 11)
        {
            questions.popUpText.text = "Enter valid phone Number";
            questions.popoUPs.SetTrigger("Do");
            return;
        }
        if (name.Length <2)
        {
            questions.popUpText.text = "Enter valid Name";
            questions.popoUPs.SetTrigger("Do");

            return;
        }
        if (age.Length < 1)
        {
            questions.popUpText.text = "Enter valid Age";
            questions.popoUPs.SetTrigger("Do");

            return;
        }
        if (gender.Length < 1)
        {
            questions.popUpText.text = "Enter valid Gender";
            questions.popoUPs.SetTrigger("Do");

            return;
        }
        questions.phase_1.SetActive(false);
        questions.phase_2.SetActive(true);
        questions.BgImage.sprite = questions.A1;
        Save(names, phone, age, gender);
    }
    public Question questions;

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
        print(path);
        w.WriteLine(name);
        w.WriteLine(phone);
        w.WriteLine(email);
        w.WriteLine(copm);
        w.WriteLine("_______>-<_______");
        w.Close();
    }
}
