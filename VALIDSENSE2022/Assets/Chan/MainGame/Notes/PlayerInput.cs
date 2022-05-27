using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField]
    private double judgeTime;

    [SerializeField]
    GameObject gameManager;

    [SerializeField]
    public int[] lineNoteNum;



    void Update()
    {
        if (NoteDataListCreater.listNumMax[0]  > lineNoteNum[0])
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                if (NoteDataListCreater.noteList_0[lineNoteNum[0]].time - MusicData.Timer < judgeTime)
                {
                    gameManager.GetComponent<NotesJudge>().NotesJudgement(
                        (long)Mathf.Abs(NoteDataListCreater.noteList_0[lineNoteNum[0]].time - MusicData.Timer), 0);
                    lineNoteNum[0]++;
                }
            }
            else if (NoteDataListCreater.noteList_0[lineNoteNum[0]].time - MusicData.Timer < (long) ConstRepo.poorTiming)
            {
                gameManager.GetComponent<NotesJudge>().NotesJudgement(
                    (long)Mathf.Abs(NoteDataListCreater.noteList_0[lineNoteNum[0]].time - MusicData.Timer), 0);
                lineNoteNum[0]++;
            }
        }


        if (NoteDataListCreater.listNumMax[1] > lineNoteNum[1])
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                if (NoteDataListCreater.noteList_1[lineNoteNum[1]].time - MusicData.Timer < judgeTime)
                {
                    gameManager.GetComponent<NotesJudge>().NotesJudgement(
                        (long)(Mathf.Abs(NoteDataListCreater.noteList_1[lineNoteNum[1]].time) - MusicData.Timer), 1);
                    lineNoteNum[1]++;
                }
            }
            else if (NoteDataListCreater.noteList_1[lineNoteNum[1]].time - MusicData.Timer < (long)ConstRepo.poorTiming)
            {
                gameManager.GetComponent<NotesJudge>().NotesJudgement(
                    (long)Mathf.Abs(NoteDataListCreater.noteList_1[lineNoteNum[1]].time - MusicData.Timer), 1);
                lineNoteNum[1]++;
            }
        }

        if (NoteDataListCreater.listNumMax[2] > lineNoteNum[2])
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                if (NoteDataListCreater.noteList_2[lineNoteNum[2]].time - MusicData.Timer < judgeTime)
                {
                    gameManager.GetComponent<NotesJudge>().NotesJudgement(
                        (long)(Mathf.Abs(NoteDataListCreater.noteList_2[lineNoteNum[2]].time) - MusicData.Timer), 2);
                    lineNoteNum[2]++;
                }
            }
            else if (NoteDataListCreater.noteList_2[lineNoteNum[2]].time - MusicData.Timer < (long)ConstRepo.poorTiming)
            {
                gameManager.GetComponent<NotesJudge>().NotesJudgement(
                    (long)Mathf.Abs(NoteDataListCreater.noteList_2[lineNoteNum[2]].time - MusicData.Timer), 2);
                lineNoteNum[2]++;
            }
        }

        if (NoteDataListCreater.listNumMax[3] > lineNoteNum[3])
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                if (NoteDataListCreater.noteList_3[lineNoteNum[3]].time - MusicData.Timer < judgeTime)
                {
                    gameManager.GetComponent<NotesJudge>().NotesJudgement(
                        (long)(Mathf.Abs(NoteDataListCreater.noteList_3[lineNoteNum[3]].time) - MusicData.Timer), 3);
                    lineNoteNum[3]++;
                }
            }
            else if (NoteDataListCreater.noteList_3[lineNoteNum[3]].time - MusicData.Timer < (long)ConstRepo.poorTiming)
            {
                gameManager.GetComponent<NotesJudge>().NotesJudgement(
                    (long)Mathf.Abs(NoteDataListCreater.noteList_3[lineNoteNum[3]].time - MusicData.Timer), 3);
                lineNoteNum[3]++;
            }
        }

    }
}
