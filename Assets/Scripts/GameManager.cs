using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameObject smallSeed;
    public Text timeTxt;

    float sec = 0f;
    float min = 0f;


    // ¾¾¾Ñ °ü·Ã
    float seedRegen = 0f;
    bool seedGen = false;
    int seedAmount = 0;


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        Application.targetFrameRate = 60;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        sec += Time.deltaTime;
        timeTxt.text = sec.ToString("N0");
        //  if (sec >= 60f)
        //  {
        //     min += 1f;
        //     sec = 0f;
        //  }
        //  timeTxt.text = string.Format("{0:D2}:{1:D2}", min, (int)sec);

        // ¾¾¾ÑÀÌ »ý¼ºµÉ ÁÂÇ¥ ¹è¿­
        // [7, 0], [14, 0], [-7, 0], [-14, 0], [0, 7], [0, 14], [0, -7], [0, -14]


        // ¾¾¾Ñ »ý¼º ¸ÞÄ¿´ÏÁò
        seedRegen += Time.deltaTime;
        if (seedRegen > 5f && !seedGen)
        {
        
            
            Plant();
            seedRegen = 0f;
            seedGen = true;
        }

    }
    public void Plant()
    {
        for (seedAmount = -14; seedAmount < 15; seedAmount += 7)
        {
            GameObject newSeed = Instantiate(smallSeed);
            newSeed.transform.position = new Vector3(7f, 0, 0);
        }

    }

}
