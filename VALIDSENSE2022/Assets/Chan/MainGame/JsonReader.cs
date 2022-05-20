using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class JsonReader : MonoBehaviour
{
    public enum NoteType
    {
        tap,
        hold
    }

    public TextAsset textJSON;

    [System.Serializable]
    public class SongData
    {
        public string name;
        public int songnum;
        public float bpm;
        public int offset;
    }

    [System.Serializable]
    public class NoteList
    {
        public int type;
        public int line;
        public long time;
        public int endtime;
    }

    [System.Serializable]
    public class Easy
    {
        public NoteList[] notelist;
    }
    
    [System.Serializable]
    public class Normal
    {
        public NoteList[] notelist;
    }

    [System.Serializable]
    public class Hard
    {
        public NoteList[] notelist;
    }

    [System.Serializable]
    public class DiffList
    {
        public Easy easy;
        public Normal normal;
        public Hard hard;
    }

    [System.Serializable]
    public class SongList
    {
        public SongData songdata;
        public DiffList difflist;
    }

    public SongList _songList = new SongList();


    void Awake() 
    {
        _songList = JsonUtility.FromJson<SongList>(textJSON.text);
    }
    void Update() 
    {
        
    }
}
