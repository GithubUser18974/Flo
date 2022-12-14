using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DataSave : MonoBehaviour
{
    public string names, phone, gender, age;
    public TMP_InputField nameInp, phoneInp, genderInp, ageInp;
    public void SetName( )
    {
        names = nameInp.text;

    }
    public void SetPhone()
    {
        phone = phoneInp.text;
    }
    public void SetGender()
    {
        gender = genderInp.text;
    }
    public void SetAge()
    {
        age = ageInp.text;
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
    }
    public Question questions;
}
