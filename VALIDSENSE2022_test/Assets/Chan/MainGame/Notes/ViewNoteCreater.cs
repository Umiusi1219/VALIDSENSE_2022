using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewNoteCreater : MonoBehaviour
{
    [SerializeField] List<GameObject> viewNotes;

    [SerializeField] List<GameObject> line0ViewNoteList;
    [SerializeField] List<GameObject> line1ViewNoteList;
    //[SerializeField] List<GameObject> line0ViewNoteList;
    //[SerializeField] List<GameObject> line0ViewNoteList;

    public int line0ViewNoteNum = 0;
    public int line1ViewNoteNum = 0;

    [SerializeField] private float instantiatePosY;

    [SerializeField] private float[] instantiatePosX;

    [SerializeField] long viewNoteTime;

    public float viewNoteSpeed;

    private void FixedUpdate()
    {
        if (NoteDataListCreater.listNumMax0 > line0ViewNoteNum)
        {
            if((NoteDataListCreater.noteList_0[line0ViewNoteNum].time - viewNoteTime) <= MusicData.Timer)
            {
                Debug.Log("noteList_0[line0ViewNoteNum].time - viewNoteTime");
                Debug.Log(NoteDataListCreater.noteList_0[line0ViewNoteNum].time - viewNoteTime);
                Debug.Log("NoteCreateTime");
                Debug.Log(MusicData.Timer);
                Debug.Log("noteList_0[line0ViewNoteNum].time");
                Debug.Log(NoteDataListCreater.noteList_0[line0ViewNoteNum].time);

                Debug.Log("noteList_0[line0ViewNoteNum].type");
                Debug.Log(NoteDataListCreater.noteList_0[line0ViewNoteNum].type);

                line0ViewNoteList.Add(viewNotes[NoteDataListCreater.noteList_0[line0ViewNoteNum].type]);
                line0ViewNoteList[line0ViewNoteNum].GetComponent<NoteView>().NoteSpeedSetter((instantiatePosY * viewNoteSpeed) / (viewNoteTime / 1000f) /60);

                Instantiate(line0ViewNoteList[line0ViewNoteNum],
                    new Vector3(instantiatePosX[NoteDataListCreater.noteList_0[line0ViewNoteNum].line], instantiatePosY * viewNoteSpeed, 87.5f),
                    new Quaternion(0, 0, 0, 0));



                line0ViewNoteNum++;
            }
        }

        if (NoteDataListCreater.listNumMax1 > line1ViewNoteNum)
        {
            if ((NoteDataListCreater.noteList_1[line1ViewNoteNum].time - viewNoteTime) <= MusicData.Timer)
            {
                Debug.Log("noteList_1[line1ViewNoteNum].time - viewNoteTime");
                Debug.Log(NoteDataListCreater.noteList_1[line1ViewNoteNum].time - viewNoteTime);
                Debug.Log("NoteCreateTime");
                Debug.Log(MusicData.Timer);
                Debug.Log("noteList_1[line1ViewNoteNum].time");
                Debug.Log(NoteDataListCreater.noteList_1[line1ViewNoteNum].time);

                Debug.Log("noteList_1[line1ViewNoteNum].type");
                Debug.Log(NoteDataListCreater.noteList_1[line1ViewNoteNum].type);

                line1ViewNoteList.Add(viewNotes[NoteDataListCreater.noteList_1[line1ViewNoteNum].type]);
                line1ViewNoteList[line1ViewNoteNum].GetComponent<NoteView>().NoteSpeedSetter((instantiatePosY * viewNoteSpeed) / (viewNoteTime / 1000f) / 60);

                Instantiate(line1ViewNoteList[line1ViewNoteNum],
                    new Vector3(instantiatePosX[NoteDataListCreater.noteList_1[line1ViewNoteNum].line], instantiatePosY * viewNoteSpeed, 87.5f),
                    new Quaternion(0, 0, 0, 0));



                line1ViewNoteNum++;
            }
        }

    }


}
