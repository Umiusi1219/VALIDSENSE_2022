using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewNoteCreater : MonoBehaviour
{
    [SerializeField] 
    List<GameObject> viewNotes;

    [SerializeField] 
    List<GameObject> line0ViewNoteList;
    [SerializeField] 
    List<GameObject> line1ViewNoteList;
    [SerializeField] 
    List<GameObject> line2ViewNoteList;
    [SerializeField] 
    List<GameObject> line3ViewNoteList;

    [SerializeField] 
    public int[] lineViewNoteNum ;

    [SerializeField] 
    public int[] lineViewNoteDereatNum;

    [SerializeField] 
    private float instantiatePosY;

    [SerializeField] 
    private float[] instantiatePosX;

    [SerializeField,Range(0,9000)] 
    long viewNoteTime = 4500;

    [Range(0.5f,30.0f)]
    public float viewNoteSpeed;

    private void FixedUpdate()
    {
        if (NoteDataListCreater.listNumMax[0] > lineViewNoteNum[0])
        {
            if((NoteDataListCreater.noteList_0[lineViewNoteNum[0]].time - viewNoteTime) <= MusicData.Timer)
            {
                Debug.Log("noteList_0[lineViewNoteNum[0]].time - viewNoteTime");
                Debug.Log(NoteDataListCreater.noteList_0[lineViewNoteNum[0]].time - viewNoteTime);
                Debug.Log("NoteCreateTime");
                Debug.Log(MusicData.Timer);
                Debug.Log("noteList_0[lineViewNoteNum[0]].time");
                Debug.Log(NoteDataListCreater.noteList_0[lineViewNoteNum[0]].time);

                Debug.Log("noteList_0[lineViewNoteNum[0]].type");
                Debug.Log(NoteDataListCreater.noteList_0[lineViewNoteNum[0]].type);

                //line0ViewNoteList.Add(viewNotes[NoteDataListCreater.noteList_0[lineViewNoteNum[0]].type]);

                line0ViewNoteList.Add(
                    Instantiate(viewNotes[NoteDataListCreater.noteList_0[lineViewNoteNum[0]].type],
                    new Vector3(instantiatePosX[NoteDataListCreater.noteList_0[lineViewNoteNum[0]].line], instantiatePosY * viewNoteSpeed, 87.5f),
                    new Quaternion(0, 0, 0, 0)) as GameObject);
                line0ViewNoteList[lineViewNoteNum[0]].GetComponent<NoteView>().NoteSpeedSetter((instantiatePosY * viewNoteSpeed) / (viewNoteTime / 1000f) / 60);


                lineViewNoteNum[0]++;
            }
        }

        if (NoteDataListCreater.listNumMax[1] > lineViewNoteNum[1])
        {
            if ((NoteDataListCreater.noteList_1[lineViewNoteNum[1]].time - viewNoteTime) <= MusicData.Timer)
            {
                Debug.Log("noteList_1[line1ViewNoteNum].time - viewNoteTime");
                Debug.Log(NoteDataListCreater.noteList_1[lineViewNoteNum[1]].time - viewNoteTime);
                Debug.Log("NoteCreateTime");
                Debug.Log(MusicData.Timer);
                Debug.Log("noteList_1[line1ViewNoteNum].time");
                Debug.Log(NoteDataListCreater.noteList_1[lineViewNoteNum[1]].time);

                Debug.Log("noteList_1[line1ViewNoteNum].type");
                Debug.Log(NoteDataListCreater.noteList_1[lineViewNoteNum[1]].type);

                //line1ViewNoteList.Add(viewNotes[NoteDataListCreater.noteList_1[lineViewNoteNum[1]].type]);

                line1ViewNoteList.Add(
                    Instantiate(viewNotes[NoteDataListCreater.noteList_1[lineViewNoteNum[1]].type],
                    new Vector3(instantiatePosX[NoteDataListCreater.noteList_1[lineViewNoteNum[1]].line], instantiatePosY * viewNoteSpeed, 87.5f),
                    new Quaternion(0, 0, 0, 0)) as GameObject);
                line1ViewNoteList[lineViewNoteNum[1]].GetComponent<NoteView>().NoteSpeedSetter((instantiatePosY * viewNoteSpeed) / (viewNoteTime / 1000f) / 60);


                lineViewNoteNum[1]++;
            }
        }

        if (NoteDataListCreater.listNumMax[2] > lineViewNoteNum[2])
        {
            if ((NoteDataListCreater.noteList_2[lineViewNoteNum[2]].time - viewNoteTime) <= MusicData.Timer)
            {
                Debug.Log("noteList_1[line1ViewNoteNum].time - viewNoteTime");
                Debug.Log(NoteDataListCreater.noteList_2[lineViewNoteNum[2]].time - viewNoteTime);
                Debug.Log("NoteCreateTime");
                Debug.Log(MusicData.Timer);
                Debug.Log("noteList_1[line1ViewNoteNum].time");
                Debug.Log(NoteDataListCreater.noteList_2[lineViewNoteNum[2]].time);

                Debug.Log("noteList_1[line1ViewNoteNum].type");
                Debug.Log(NoteDataListCreater.noteList_2[lineViewNoteNum[2]].type);

                //line1ViewNoteList.Add(viewNotes[NoteDataListCreater.noteList_1[lineViewNoteNum[1]].type]);

                line2ViewNoteList.Add(
                    Instantiate(viewNotes[NoteDataListCreater.noteList_2[lineViewNoteNum[2]].type],
                    new Vector3(instantiatePosX[NoteDataListCreater.
                    noteList_2[lineViewNoteNum[2]].line], instantiatePosY * viewNoteSpeed, 87.5f),
                    new Quaternion(0, 0, 0, 0)) as GameObject);

                line2ViewNoteList[lineViewNoteNum[2]].GetComponent<NoteView>().
                    NoteSpeedSetter((instantiatePosY * viewNoteSpeed) / (viewNoteTime / 1000f) / 60);


                lineViewNoteNum[2]++;
            }
        }

        if (NoteDataListCreater.listNumMax[3] > lineViewNoteNum[3])
        {
            if ((NoteDataListCreater.noteList_3[lineViewNoteNum[3]].time - viewNoteTime) <= MusicData.Timer)
            {
                Debug.Log("noteList_1[line1ViewNoteNum].time - viewNoteTime");
                Debug.Log(NoteDataListCreater.noteList_3[lineViewNoteNum[3]].time - viewNoteTime);
                Debug.Log("NoteCreateTime");
                Debug.Log(MusicData.Timer);
                Debug.Log("noteList_1[line1ViewNoteNum].time");
                Debug.Log(NoteDataListCreater.noteList_3[lineViewNoteNum[3]].time);

                Debug.Log("noteList_1[line1ViewNoteNum].type");
                Debug.Log(NoteDataListCreater.noteList_3[lineViewNoteNum[3]].type);

                //line1ViewNoteList.Add(viewNotes[NoteDataListCreater.noteList_1[lineViewNoteNum[1]].type]);

                line3ViewNoteList.Add(
                    Instantiate(viewNotes[NoteDataListCreater.noteList_3[lineViewNoteNum[3]].type],
                    new Vector3(instantiatePosX[NoteDataListCreater.
                    noteList_3[lineViewNoteNum[3]].line], instantiatePosY * viewNoteSpeed, 87.5f),
                    new Quaternion(0, 0, 0, 0)) as GameObject);

                line3ViewNoteList[lineViewNoteNum[3]].GetComponent<NoteView>().
                    NoteSpeedSetter((instantiatePosY * viewNoteSpeed) / (viewNoteTime / 1000f) / 60);


                lineViewNoteNum[3]++;
            }
        }

    }


    public void NowNoteFadeOut(int line)
    {
        switch(line)
        {
            case 0:
                Debug.Log(lineViewNoteDereatNum[0]);
                line0ViewNoteList[lineViewNoteDereatNum[0]].GetComponent<NoteView>().NoteFadeOut();
                lineViewNoteDereatNum[0]++;
                break;

            case 1:
                Debug.Log(lineViewNoteDereatNum[1]);
                line1ViewNoteList[lineViewNoteDereatNum[1]].GetComponent<NoteView>().NoteFadeOut();
                lineViewNoteDereatNum[1]++;
                break;

            case 2:
                Debug.Log(lineViewNoteDereatNum[2]);
                line2ViewNoteList[lineViewNoteDereatNum[2]].GetComponent<NoteView>().NoteFadeOut();
                lineViewNoteDereatNum[2]++;
                break;

            case 3:
                Debug.Log(lineViewNoteDereatNum[3]);
                line3ViewNoteList[lineViewNoteDereatNum[3]].GetComponent<NoteView>().NoteFadeOut();
                lineViewNoteDereatNum[3]++;
                break;
        }
    }
}
