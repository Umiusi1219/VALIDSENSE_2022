using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NotesJudge : MonoBehaviour
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


    [SerializeField] 
    GameObject viewNoteCreater;


    [SerializeField]
    List<GameObject> effectList;

    [SerializeField] 
    private float[] instancePosXs;

    [SerializeField]
    Text text;


    public static NotesJudge instance;

    private void Awake()
    {
         if(instance = null)
        {
            instance = this;
        }
    }


    public void NotesJudgement(long time, int line)
    {
        
        if(time <= briliantJudge)
        {
            Debug.Log(JudgeType.Briliant);
            Debug.Log("JudgeTime" + MusicData.Timer);
            Instantiate(effectList[(int)JudgeType.Briliant],
                new Vector3(instancePosXs[line], 3.0f,80.0f),new Quaternion(0, 0, 0, 0));


        }
        else if(time <= greatJudge)
        {
            Debug.Log(JudgeType.Great);
            Debug.Log("JudgeTime" + MusicData.Timer);
            Instantiate(effectList[(int)JudgeType.Great],
                new Vector3(instancePosXs[line], 3.0f, 80.0f), new Quaternion(0, 0, 0, 0));


        }
        else if(time <= goodJudge)
        {
            Debug.Log(JudgeType.Good);
            Debug.Log("JudgeTime" + MusicData.Timer);
            Instantiate(effectList[(int)JudgeType.Good],
                new Vector3(instancePosXs[line], 3.0f, 80.0f), new Quaternion(0, 0, 0, 0));


        }
        else
        {
            Debug.Log(JudgeType.Poor);
            Debug.Log("JudgeTime" + MusicData.Timer);
            Instantiate(effectList[(int)JudgeType.Poor],
                new Vector3(instancePosXs[line], 3.0f, 80.0f), new Quaternion(0, 0, 0, 0));


        }

        
        viewNoteCreater.GetComponent<ViewNoteCreater>().NowNoteFadeOut(line);
    } 


}
