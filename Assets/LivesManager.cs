using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class LivesManager : MonoBehaviour
{
    private static LivesManager _instance;

    public static LivesManager Instance
    {
        get
        {
            if (_instance == null)
            {
                GameObject gameObject = new GameObject("LivesManager");
                gameObject.AddComponent<LivesManager>();
            }

            return _instance;
        }
    }

    void Awake()
    {
        _instance = this;
    }



    public Text liveText;
    int liveLeft = 5;

    void Start()
    {
        liveText.text = "Lives x" + liveLeft.ToString();
    }

    public void LossingLive(int less)
    {
        liveLeft -= less;
        if(liveLeft < 0)
            liveLeft = 0;
        liveText.text = "Lives x" + liveLeft.ToString();
    }
}
