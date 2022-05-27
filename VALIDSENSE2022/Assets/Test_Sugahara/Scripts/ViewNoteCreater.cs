using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewNoteCreater : MonoBehaviour
{
    /// <summary>
    /// �\���p�m�[�c�𐶐�����ׂɁA�f�ނ��i�[���Ă���List
    /// </summary>
    [SerializeField] 
    List<GameObject> viewNotes;

    /// <summary>
    /// �\���p�m�[�c�i�[line���ƂɊi�[���A��������View�m�[�c���Ǘ�����p
    /// 0�ԃ��C��
    /// </summary>
    [SerializeField] 
    List<GameObject> line0ViewNoteList;

    /// <summary>
    /// �\���p�m�[�c�i�[line���ƂɊi�[���A��������View�m�[�c���Ǘ�����p
    /// 1�ԃ��C��
    /// </summary>
    [SerializeField] 
    List<GameObject> line1ViewNoteList;


    /// <summary>
    /// �\���p�m�[�c�i�[line���ƂɊi�[���A��������View�m�[�c���Ǘ�����p
    /// 2�ԃ��C��
    /// </summary>
    [SerializeField] 
    List<GameObject> line2ViewNoteList;


    /// <summary>
    /// �\���p�m�[�c�i�[line���ƂɊi�[���A��������View�m�[�c���Ǘ�����p
    /// 3�ԃ��C��
    /// </summary>
    [SerializeField] 
    List<GameObject> line3ViewNoteList;


    /// <summary>
    /// �e���C�������Ԗڂ�View�m�[�c�Ɋ����邩�A�Ǘ��p
    /// </summary>
    [SerializeField] 
    public int[] lineViewNoteNum ;


    /// <summary>
    /// �e���C�������Ԗڂ�View�m�[�c���������A�Ǘ��p
    /// </summary>
    [SerializeField] 
    public int[] lineViewNoteDereatNum;


    /// <summary>
    /// View�m�[�c���ǂ̍������琶�����邩�́A��Ƃ��Ďg�����l
    /// </summary>
    [SerializeField] 
    private float instantiatePosY;


    /// <summary>
    /// View�m�[�c���e���C���ɐ������鎞�p�̔z��
    /// </summary>
    [SerializeField] 
    private float[] instantiatePosX;


    /// <summary>
    /// View�m�[�c���ǂ̉��s�Ő������鎞�p�̐��l
    /// </summary>
    [SerializeField]
    private float instantiatePosZ;


    /// <summary>
    /// View�m�[�c���A����o�[���B���鎞�Ԃ��Am/s�b�����������邩�́A�l
    /// </summary>
    [SerializeField,Range(0,9000)] 
    long viewNoteTime = 4500;


    /// <summary>
    /// View�m�[�c���ǂꂭ�炢�̑����ŗ������̊�ɂȂ�A�l
    /// </summary>
    [Range(0.5f,30.0f)]
    public float viewNoteSpeed;


    private void FixedUpdate()
    {

        if (NoteDataListCreater.listNumMax[0] > lineViewNoteNum[0])
        {
            if((NoteDataListCreater.noteList_0[lineViewNoteNum[0]].time - viewNoteTime) <= MusicData.Timer)
            {
                /* �f�o�b�N�p
                Debug.Log("noteList_0[lineViewNoteNum[0]].time - viewNoteTime");
                Debug.Log(NoteDataListCreater.noteList_0[lineViewNoteNum[0]].time - viewNoteTime);
                Debug.Log("NoteCreateTime");
                Debug.Log(MusicData.Timer);
                Debug.Log("noteList_0[lineViewNoteNum[0]].time");
                Debug.Log(NoteDataListCreater.noteList_0[lineViewNoteNum[0]].time);
                Debug.Log("noteList_0[lineViewNoteNum[0]].type");
                Debug.Log(NoteDataListCreater.noteList_0[lineViewNoteNum[0]].type);
                 */

                //line0ViewNoteList.Add(viewNotes[NoteDataListCreater.noteList_0[lineViewNoteNum[0]].type]);


                // ���C��0��View�m�[�c���Ǘ�����List�ɁA
                line0ViewNoteList.Add(
                    Instantiate(viewNotes[NoteDataListCreater.noteList_0[lineViewNoteNum[0]].type],
                    new Vector3(instantiatePosX[NoteDataListCreater.
                    noteList_0[lineViewNoteNum[0]].line], instantiatePosY * viewNoteSpeed, instantiatePosZ),
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
                    new Vector3(instantiatePosX[NoteDataListCreater.
                    noteList_1[lineViewNoteNum[1]].line], instantiatePosY * viewNoteSpeed, instantiatePosZ),
                    new Quaternion(0, 0, 0, 0)) as GameObject);
                line1ViewNoteList[lineViewNoteNum[1]].GetComponent<NoteView>().NoteSpeedSetter((instantiatePosY * viewNoteSpeed) / (viewNoteTime / 1000f) / 60);


                lineViewNoteNum[1]++;
            }
        }

        if (NoteDataListCreater.listNumMax[2] > lineViewNoteNum[2])
        {
            if ((NoteDataListCreater.noteList_2[lineViewNoteNum[2]].time - viewNoteTime) <= MusicData.Timer)
            {
                /*
                Debug.Log("noteList_1[line1ViewNoteNum].time - viewNoteTime");
                Debug.Log(NoteDataListCreater.noteList_2[lineViewNoteNum[2]].time - viewNoteTime);
                Debug.Log("NoteCreateTime");
                Debug.Log(MusicData.Timer);
                Debug.Log("noteList_1[line1ViewNoteNum].time");
                Debug.Log(NoteDataListCreater.noteList_2[lineViewNoteNum[2]].time);

                Debug.Log("noteList_1[line1ViewNoteNum].type");
                Debug.Log(NoteDataListCreater.noteList_2[lineViewNoteNum[2]].type);
                */

                //line1ViewNoteList.Add(viewNotes[NoteDataListCreater.noteList_1[lineViewNoteNum[1]].type]);

                line2ViewNoteList.Add(
                    Instantiate(viewNotes[NoteDataListCreater.noteList_2[lineViewNoteNum[2]].type],
                    new Vector3(instantiatePosX[NoteDataListCreater.
                    noteList_2[lineViewNoteNum[2]].line], instantiatePosY * viewNoteSpeed, instantiatePosZ),
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
                /*
                Debug.Log("noteList_1[line1ViewNoteNum].time - viewNoteTime");
                Debug.Log(NoteDataListCreater.noteList_3[lineViewNoteNum[3]].time - viewNoteTime);
                Debug.Log("NoteCreateTime");
                Debug.Log(MusicData.Timer);
                Debug.Log("noteList_1[line1ViewNoteNum].time");
                Debug.Log(NoteDataListCreater.noteList_3[lineViewNoteNum[3]].time);

                Debug.Log("noteList_1[line1ViewNoteNum].type");
                Debug.Log(NoteDataListCreater.noteList_3[lineViewNoteNum[3]].type);
                */

                //line1ViewNoteList.Add(viewNotes[NoteDataListCreater.noteList_1[lineViewNoteNum[1]].type]);

                line3ViewNoteList.Add(
                    Instantiate(viewNotes[NoteDataListCreater.noteList_3[lineViewNoteNum[3]].type],
                    new Vector3(instantiatePosX[NoteDataListCreater.
                    noteList_3[lineViewNoteNum[3]].line], instantiatePosY * viewNoteSpeed, instantiatePosZ),
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
