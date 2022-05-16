using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField]
    private double judgeTime;

    [SerializeField]
    GameObject gameManager;


     public static int line0NoteNum = 0;
     public static int line1NoteNum = 0;



    void Update()
    {
        if (NoteDataListCreater.listNumMax0  >  line0NoteNum)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                if (NoteDataListCreater.noteList_0[line0NoteNum].time - MusicData.Timer < judgeTime)
                {
                    gameManager.GetComponent<NoteJudge>().NoteJudgement((long)Mathf.Abs(NoteDataListCreater.noteList_0[line0NoteNum].time - MusicData.Timer), 0);
                    line0NoteNum++;
                }
            }
            else if (NoteDataListCreater.noteList_0[line0NoteNum].time - MusicData.Timer <= -105)
            {
                gameManager.GetComponent<NoteJudge>().NoteJudgement((long)Mathf.Abs(NoteDataListCreater.noteList_0[line0NoteNum].time - MusicData.Timer), 0);
                line0NoteNum++;
            }
        }


        if (NoteDataListCreater.listNumMax1 > line1NoteNum)
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                if (NoteDataListCreater.noteList_1[line1NoteNum].time - MusicData.Timer < judgeTime)
                {
                    gameManager.GetComponent<NoteJudge>().NoteJudgement((long)(Mathf.Abs(NoteDataListCreater.noteList_1[line1NoteNum].time) - MusicData.Timer), 1);
                    line1NoteNum++;
                }
            }
            else if (NoteDataListCreater.noteList_1[line1NoteNum].time - MusicData.Timer <= -105)
            {
                gameManager.GetComponent<NoteJudge>().NoteJudgement((long)Mathf.Abs(NoteDataListCreater.noteList_1[line1NoteNum].time - MusicData.Timer), 1);
                line1NoteNum++;
            }
        }


    }
}
