using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteCreater : MonoBehaviour
{
    [SerializeField]
    List<GameObject> noteViewList;
    [SerializeField]
    private List<JsonReader.NoteList> line0, line1;
    [SerializeField]
    private List<GameObject> NoteViewLineList0, NoteViewLineList1;

    void Start()
    {
        line0 = NoteDataListCreater.noteList_0;
        line1 = NoteDataListCreater.noteList_1;
    }
    // Update is called once per frame
    void Update()
    {

    }
}
