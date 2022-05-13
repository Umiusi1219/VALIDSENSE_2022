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

    public void NoteJudgement(long time, int line)
    {
        
        if(time <= briliantJudge)
        {
            Debug.Log(JudgeType.Briliant);
        }
        else if(time <= greatJudge)
        {
            Debug.Log(JudgeType.Great);
        }
        else if(time <= goodJudge)
        {
            Debug.Log(JudgeType.Good);
        }
        else
        {
            Debug.Log(JudgeType.Poor);
        }

    } 


    // Update is called once per frame
    void Update()
    {
        
    }
}
