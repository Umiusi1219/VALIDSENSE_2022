using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    private CriAtomEx.CueInfo[] SongcueInfoList,SEcueInfoList;
    private CriAtomExPlayer SongPlayer,SEPlayer;
    private CriAtomExAcb SongExAcb,SEExAcb;
    private CriAtomExPlayback SongPlayback,SEPlayback;
    public static MusicPlayer instance;
    public long PlayTime;
    public static int SongNum = 0;

    private void Awake() 
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    IEnumerator Start()
    {
        /* キューシートファイルのロード待ち */
        while (CriAtom.CueSheetsAreLoading) { yield return null; }
        /* Cue情報の取得 */
        SongExAcb = CriAtom.GetAcb("BGMCueSheet");
        SongcueInfoList = SongExAcb.GetCueInfoList();
        SEExAcb = CriAtom.GetAcb("SECue");
        SEcueInfoList = SEExAcb.GetCueInfoList();

        /* AtomExPlayerの生成 */
        SongPlayer = new CriAtomExPlayer(true);

        SEPlayer = new CriAtomExPlayer();    
        
    }
    private void Update() 
    {
        PlayTime = SongPlayback.GetTimeSyncedWithAudio();
        MusicData.Timer = PlayTime;
    }
    public void Music_Play(int num)
    {
        if(SongPlayer.GetStatus() == CriAtomExPlayer.Status.Playing) 
        {
            SongPlayer.Stop();
        }
        SongPlayer.SetCue(SongExAcb,SongcueInfoList[num].name);
        SongPlayback = SongPlayer.Start();
    }
    public void SE_Tap(int SEtype)
    {
        SEPlayer.SetCue(SEExAcb,SEcueInfoList[SEtype].name);
        SEPlayback = SEPlayer.Start();
    }
    public void SE_Tap2()
    {
        SEPlayer.SetCue(SEExAcb,SEcueInfoList[1].name);
        SEPlayback = SEPlayer.Start();
    }
    public void SE_Hold()
    {
        SEPlayer.SetCue(SEExAcb,SEcueInfoList[2].name);
        SEPlayback = SEPlayer.Start();
    }
}
