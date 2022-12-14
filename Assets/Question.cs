using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Question : MonoBehaviour
{
    public GameObject[] _Q1;
    public Toggle[] _Q1T;
    public GameObject[] _Q2;
    public Toggle[] _Q2T;
    public GameObject[] _Q3;
    public Toggle[] _Q3T;
    public GameObject[] _Q4;
    public Toggle[] _Q4T;
    public int Score = 0;
    public void Q1()
    {
        foreach(GameObject i in _Q1)
        {
            i.SetActive(true);
        }
        foreach (Toggle i in _Q1T)
        {
            i.enabled = false;
        }
    }
    public void Q2()
    {
        foreach (GameObject i in _Q2)
        {
            i.SetActive(true);
        }
        foreach (Toggle i in _Q2T)
        {
            i.enabled = false;
        }
    }
    public void Q3()
    {
        foreach (GameObject i in _Q3)
        {
            i.SetActive(true);
        }
        foreach (Toggle i in _Q3T)
        {
            i.enabled = false;
        }
    }
    public void Q4()
    {
        foreach (GameObject i in _Q4)
        {
            i.SetActive(true);
        }
        foreach (Toggle i in _Q4T)
        {
            i.enabled = false;
        }
    }
    public void IncremntScore()
    {
        Score++;
    }
    public Animator popoUPs;
    public Text popUpText;
    public int questionCount = 0;
    public AudioSource _audioSource;
    public AudioClip wrong, Right;
    public void PlayWrongAnswer()
    {
        popoUPs.SetTrigger("Do");
        popUpText.text = "Wrong Answer!";
        questionCount++;
        SetImageBG();
        _audioSource.clip = wrong;
        _audioSource.Play();
        if (questionCount == 2)
        {
            StartCoroutine(DisplayPhase3());
        }
        else if (questionCount == 4)
        {
            StartCoroutine(DisplayPhase4());

        }
    }
    public void PlayRightAnswer()
    {
        popoUPs.SetTrigger("Do");
        popUpText.text = "Correct Answer!";
        questionCount++;
        SetImageBG();
        _audioSource.clip = Right;
        _audioSource.Play();
        if (questionCount == 2)
        {
            StartCoroutine(DisplayPhase3());
        }
        else if (questionCount == 4)
        {
            StartCoroutine(DisplayPhase4());

        }
    }
    public GameObject phase_1, phase_2, phase_3, phase_4;
    IEnumerator DisplayPhase3()
    {
        yield return new WaitForSeconds(4);
        phase_1.SetActive(false);
        phase_2.SetActive(false);
        phase_3.SetActive(true);
    }
    IEnumerator DisplayPhase4()
    {
        yield return new WaitForSeconds(4);
        phase_1.SetActive(false);
        phase_2.SetActive(false);
        phase_3.SetActive(false);
        phase_4.SetActive(true);
        StartCoroutine(ReloadScene());

    }
    IEnumerator ReloadScene()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public Sprite A1, A2;
    public Image BgImage;
    private void Start()
    {
        SetIamge();
    }
    public void SetIamge()
    {
        
           // int y = PlayerPrefs.GetInt("araby");
          //  y++;
       // PlayerPrefs.SetInt("araby",y);
       // if (y % 2 == 0)
          //  {
            //    BgImage.sprite = A1;

           // }
           // else
           // {
                BgImage.sprite = A2;

           // }

       
    }
    void SetImageBG()
    {
        if(questionCount<=4)
        {
            BgImage.sprite = A1;
        }
       
        else
        {
            BgImage.sprite = A2;

        }
    }
   
    }
