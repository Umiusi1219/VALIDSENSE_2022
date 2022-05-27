using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteCreater : MonoBehaviour
{
    [SerializeField]
    List<GameObject> noteViewList;
    [SerializeField]
    private List<JsonReader.NoteList> line0, line1,line2,line3;
    [SerializeField]
    private List<GameObject> NoteViewLineList0, NoteViewLineList1,
        NoteViewLineList2, NoteViewLineList3;

    void Start()
    {
        line0 = NoteDataListCreater.noteList_0;
        line1 = NoteDataListCreater.noteList_1;
        line2 = NoteDataListCreater.noteList_2;
        line3 = NoteDataListCreater.noteList_3;
    }
    // Update is called once per frame
    void Update()
    {

    }
}
