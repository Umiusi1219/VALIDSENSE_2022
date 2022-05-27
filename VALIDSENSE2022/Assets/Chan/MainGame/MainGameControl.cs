using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainGameControl : MonoBehaviour
{
    public Text text;
    private bool isStart = false;
    // Start is called before the first frame update
    void Start()
    {
        //MusicPlayer.instance.MusicPlay(0);   
    }

    // Update is called once per frame
    void Update()
    {
        if(!isStart && Input.GetKeyDown(KeyCode.P))
        {
            MusicPlayer.instance.MusicPlay(1);   
            isStart = true;
        }
        text.text = MusicData.Timer+ "ms";
    }
}
