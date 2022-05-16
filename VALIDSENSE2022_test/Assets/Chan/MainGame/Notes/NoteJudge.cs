using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteJudge : MonoBehaviour
{
    enum JudgeType
    {
        Briliant = 0,
        Great,
        Good,
        Poor,
    }
    
    /*
    Briliant +- 20ms
    Great +- 40ms
    Good +- 100ms
    Poor
    */

    private long briliantJudge = 20;
    private long greatJudge = 40;
    private long goodJudge = 100;


    public static NoteJudge instance;

    private void Awake()
    {
         if(instance = null)
        {
            instance = this;
        }
    }


    public void NoteJudgement(long time, int line)
    {
        

        
        if(time <= briliantJudge)
        {
            Debug.Log(JudgeType.Briliant);
            Debug.Log("JudgeTime" + MusicData.Timer);
        }
        else if(time <= greatJudge)
        {
            Debug.Log(JudgeType.Great);
            Debug.Log("JudgeTime" + MusicData.Timer);
        }
        else if(time <= goodJudge)
        {
            Debug.Log(JudgeType.Good);
            Debug.Log("JudgeTime" + MusicData.Timer);
        }
        else
        {
            Debug.Log(JudgeType.Poor);
            Debug.Log("JudgeTime" + MusicData.Timer);
        }

    } 


}
