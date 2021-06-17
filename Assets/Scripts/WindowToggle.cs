using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WindowToggle : MonoBehaviour {

    Canvas cavs;

    public GameObject SCGame;

    public GameObject OCpenSc_1;

    public GameObject OCpenSc_2;


    void Start()
    {

        //获取父亲画布
        cavs = GetComponentInParent<Canvas>();
    }
    public void StartButton()
    {
        OCpenSc_1.SetActive(true);
        SCGame.SetActive(false);
    }

    public void Return()
    {
        cavs.enabled = true;
        SCGame.SetActive(true);
        OCpenSc_1.SetActive(false);
        OCpenSc_2.SetActive(false);
    }
    public void ReturnButton()
    {
        OCpenSc_1.SetActive(false);
        SCGame.SetActive(true);
    }

    public void StartButton_1()
    {
        OCpenSc_1.SetActive(false);
        OCpenSc_2.SetActive(true);
    }

    public void ReturnButton_1()
    {
        OCpenSc_2.SetActive(false);
        SCGame.SetActive(true);
    }
}
