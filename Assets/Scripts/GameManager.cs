using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;


public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameObject smallSeed;
    public GameObject bigSeed;
    public Text timeTxt;

    float sec = 0f;
    float min = 0f;


    // ¾¾¾Ñ °ü·Ã
    float seedRegen = 0f;
    bool seedGen = false;
    int seedAmount = 0;

    int[] seedsX = { 7, 14, -7, -14, 0, 0, 0, 0 };
    int[] seedsY = { 0, 0, 0, 0, 7, 14, -7, -14 };


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
        int j = UnityEngine.Random.Range(0, 8);

        for (int i = 0; i < 8; i++)
        {
            if (i != j)
            {
                GameObject newSeed = Instantiate(smallSeed);
                int x = seedsX[i];
                int y = seedsY[i];
                newSeed.transform.position = new Vector2(x, y);
            }
            else
            {
                GameObject newSeedB = Instantiate(bigSeed);
                int x = seedsX[i];
                int y = seedsY[i];
                newSeedB.transform.position = new Vector2(x, y);
            }

        }

    }

}
