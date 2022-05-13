using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteDataListCreater : MonoBehaviour
{
    public JsonReader jsonReader;
    public GameObject note;
    public GameObject list;
    
    public static List<JsonReader.NoteList> noteList_0 = new List<JsonReader.NoteList>();
    public static List<JsonReader.NoteList> noteList_1 = new List<JsonReader.NoteList>();
    //public List<JsonReader.NoteList> noteList_2 = new List<JsonReader.NoteList>();
    //public List<JsonReader.NoteList> noteList_3 = new List<JsonReader.NoteList>();



    void Start()
    {
        foreach(JsonReader.NoteList item in jsonReader._songList.difflist.easy.notelist)
        {
            Debug.Log(item.type+item.time+item.line+item.endtime);

            switch (item.line)
            {
                case 0:
                    noteList_0.Add(item);
                    break;
                case 1:
                    noteList_1.Add(item);
                    break;
                default:
                    Debug.LogError("配列外参照");
                    break;
            }

            // //instantiate notes
            // GameObject notes = Instantiate(note,list.transform);
            // var _x = item.line* 200 - 300;
            // var _y = item.time;
            // notes.transform.position = new Vector3(_x, _y * 0.2f, 0);
            // note.GetComponent<NoteData>().time = item.time;
            // note.GetComponent<NoteData>().line = item.line;
        }
    }
}
