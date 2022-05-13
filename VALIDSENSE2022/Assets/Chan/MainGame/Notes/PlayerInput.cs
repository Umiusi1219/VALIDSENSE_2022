using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField]
    private double judgeTime;

    NoteJudge noteJudge;

    public static int line0NoteNum;
    public static int line1NoteNum;


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            if (NoteDataListCreater.noteList_0[line0NoteNum].time - MusicData.Timer < 2000)
            {
                noteJudge.NoteJudgement(Mathf.Abs(NoteDataListCreater.noteList_0[line0NoteNum].time - MusicData.Timer),0);
                line0NoteNum++;
            }
        }
        
        
        if(Input.GetKeyDown(KeyCode.S))
        {
            if (NoteDataListCreater.noteList_1[line1NoteNum].time - MusicData.Timer < 2000)
            {
                noteJudge.NoteJudgement((Mathf.Abs(NoteDataListCreater.noteList_1[line1NoteNum].time) - MusicData.Timer),1);
                line1NoteNum++;
            }
        }

        if(NoteDataListCreater.noteList_0[line0NoteNum].time - MusicData.Timer >= 101)
        {
            noteJudge.NoteJudgement(Mathf.Abs(NoteDataListCreater.noteList_0[line0NoteNum].time - MusicData.Timer),0);
            line0NoteNum++;
        }
        if(NoteDataListCreater.noteList_1[line1NoteNum].time - MusicData.Timer >= 101)
        {
            noteJudge.NoteJudgement(Mathf.Abs(NoteDataListCreater.noteList_1[line1NoteNum].time - MusicData.Timer),1);
            line1NoteNum++;
        }
    }
}
