using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;     //to code the text & images ui
using TMPro;
using UnityEngine.SceneManagement;

public class buttonPractice : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI mytext;
    [SerializeField] private int mynum;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mytext.text = ("" + mynum);
    }

    public void randomize()
    {
        //Random.Range is used to return a random value between a set minimum and maximum number.
        mynum = Random.Range(1,2000);
    }
}
