using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialPlayer : MonoBehaviour

{
    private CriAtomEx.CueInfo[] TutorialList;
    private CriAtomExPlayer TutorialExPlayer;
    private CriAtomExAcb TutorialExAcb;
    private CriAtomExPlayback TutorialPlayback;
    //public long Timer;
    public long PlayTime;
    public static TutorialPlayer instance;
    public Text Timing;
    private void Awake() 
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    IEnumerator Start()
    {   
        /* キューシートファイルのロード待ち */
        while (CriAtom.CueSheetsAreLoading) { yield return null; }
        /* Cue情報の取得 */
        TutorialExAcb = CriAtom.GetAcb("tutorialCue");
        TutorialList = TutorialExAcb.GetCueInfoList();    
        TutorialExPlayer = new CriAtomExPlayer(true);   
    }

    // Update is called once per frame
    void Update()
    {
        PlayTime = TutorialPlayback.GetTimeSyncedWithAudio();
        MusicData.Timer = PlayTime;
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Tutorial_Play();
        } 
        if(Input.GetKeyDown(KeyCode.D))
        {
            MusicPlayer.instance.SE_Tap(0);
        }
        if(Input.GetKeyDown(KeyCode.F))
        {
            MusicPlayer.instance.SE_Tap(1);
        }
        //Timer = MusicData.Timer;
        Timing.text = PlayTime + "ms";
    }

    public void Tutorial_Play()
    {
        if(TutorialExPlayer.GetStatus() == CriAtomExPlayer.Status.Playing) 
        {
            TutorialExPlayer.Stop();
        }
        TutorialExPlayer.SetCue(TutorialExAcb,TutorialList[0].name);
        TutorialPlayback = TutorialExPlayer.Start();
    }
 
}
