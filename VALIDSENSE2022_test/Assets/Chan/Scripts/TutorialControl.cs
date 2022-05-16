using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialControl : MonoBehaviour
{
    public GameObject[] Msgs;
    public GameObject[] BackGround;
    public GameObject[] Countdown;
    public GameObject[] SkillMsg;
    public GameObject[] Kari;
    private float BPM = 138;
    private float beat;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("TutorialStart");
        beat = 60/BPM;
        Debug.Log(beat);
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator TutorialStart()
    {
        Debug.Log("TutorialStart");
        TutorialPlayer.instance.Tutorial_Play();
        yield return new WaitForSeconds(6);
        yield return StartCoroutine("TutorialStartMsg");
    }
    
    IEnumerator TutorialStartMsg()
    {

        Debug.Log("StartMsg");
        
        BackGround[0].SetActive(true);
        BackGround[1].SetActive(true);
        for(float i = 0f;i<1;i+= 0.1f)
        {
            BackGround[2].GetComponent<Image>().color = new Color(255,255,255,i);
            Msgs[0].GetComponent<Text>().color = new Color(255,255,255,i);
            yield return null;
        }
        yield return new WaitForSeconds(3);
        for(float i = 1f;i>=-0.05f;i-= 0.05f)
        {
            BackGround[2].GetComponent<Image>().color = new Color(255,255,255,i);
            Msgs[0].GetComponent<Text>().color = new Color(255,255,255,i);
            yield return null;
        }
        Msgs[0].SetActive(false);
        yield return StartCoroutine("Tutorial_1P");
    }
    
    IEnumerator Tutorial_1P()
    {
        Debug.Log("1P");
        BackGround[1].SetActive(false);
        for(float i = 0f;i<1;i+= 0.1f)
        {
            BackGround[3].GetComponent<Image>().color = new Color(255,255,255,i);
            Msgs[1].GetComponent<Text>().color = new Color(255,255,255,i);
            yield return null;
        }
        yield return new WaitForSeconds(3);
        for(float i = 1f;i>=-0.05f;i-= 0.05f)
        {
            BackGround[3].GetComponent<Image>().color = new Color(255,255,255,i);
            Msgs[1].GetComponent<Text>().color = new Color(255,255,255,i);
            yield return null;
        }
        Msgs[1].SetActive(false);
        BackGround[1].SetActive(true);
        yield return StartCoroutine("Tutorial_2P");
    }
    
    IEnumerator Tutorial_2P()
    {
        Debug.Log("2P");
        BackGround[0].SetActive(false);
        for(float i = 0f;i<1;i+= 0.1f)
        {
            BackGround[4].GetComponent<Image>().color = new Color(255,255,255,i);
            Msgs[2].GetComponent<Text>().color = new Color(255,255,255,i);
            yield return null;
        }
        yield return new WaitForSeconds(3);
        for(float i = 1f;i>=-0.05f;i-= 0.05f)
        {
            BackGround[4].GetComponent<Image>().color = new Color(255,255,255,i);
            Msgs[2].GetComponent<Text>().color = new Color(255,255,255,i);
            yield return null;
        }
        Msgs[2].SetActive(false);
        BackGround[0].SetActive(true);
        yield return StartCoroutine("WinMsg");
    }
    
    IEnumerator WinMsg()
    {
        for(float i = 0f;i<1;i+= 0.1f)
        {
            BackGround[2].GetComponent<Image>().color = new Color(255,255,255,i);
            Msgs[3].GetComponent<Text>().color = new Color(255,255,255,i);
            yield return null;
        }
        yield return new WaitForSeconds(3);
        for(float i = 1f;i>=-0.05f;i-= 0.05f)
        {
            BackGround[2].GetComponent<Image>().color = new Color(255,255,255,i);
            Msgs[3].GetComponent<Text>().color = new Color(255,255,255,i);
            yield return null;
        }
        Msgs[3].SetActive(false);
        BackGround[0].SetActive(false);
        BackGround[1].SetActive(false);
        yield return StartCoroutine("TutorialTapMsg");
    }
    
    IEnumerator TutorialTapMsg()
    {
        for(float i = 0f;i<1;i+= 0.1f)
        {
            BackGround[2].GetComponent<Image>().color = new Color(255,255,255,i);
            Msgs[4].GetComponent<Text>().color = new Color(255,255,255,i);
            yield return null;
        }
        yield return new WaitForSeconds(3);
        for(float i = 1f;i>=-0.05f;i-= 0.05f)
        {
            BackGround[2].GetComponent<Image>().color = new Color(255,255,255,i);
            Msgs[4].GetComponent<Text>().color = new Color(255,255,255,i);
            yield return null;
        }
        Msgs[4].SetActive(false);
        yield return StartCoroutine("TutorialTapMove");
    }
    
    IEnumerator TutorialTapMove()
    {
        Countdown[0].SetActive(true);
        yield return new WaitForSeconds(beat);
        Countdown[0].SetActive(false);
        Countdown[1].SetActive(true);
        yield return new WaitForSeconds(beat);
        Countdown[1].SetActive(false);
        Countdown[2].SetActive(true);
        yield return new WaitForSeconds(beat);
        Countdown[2].SetActive(false);
        Debug.Log("TapMove");

        Kari[0].SetActive(true);
        yield return new WaitForSeconds(5);
        Kari[0].SetActive(false);

        yield return StartCoroutine("TutorialHoldMsg");
    }
    
    IEnumerator TutorialHoldMsg()
    {
        for(float i = 0f;i<1;i+= 0.1f)
        {
            BackGround[2].GetComponent<Image>().color = new Color(255,255,255,i);
            Msgs[5].GetComponent<Text>().color = new Color(255,255,255,i);
            yield return null;
        }
        yield return new WaitForSeconds(3);
        for(float i = 1f;i>=-0.05f;i-= 0.05f)
        {
            BackGround[2].GetComponent<Image>().color = new Color(255,255,255,i);
            Msgs[5].GetComponent<Text>().color = new Color(255,255,255,i);
            yield return null;
        }
        Msgs[5].SetActive(false);
        yield return StartCoroutine("TutorialHoldMove");
    }
    
    IEnumerator TutorialHoldMove()
    {
        Countdown[0].SetActive(true);
        yield return new WaitForSeconds(beat);
        Countdown[0].SetActive(false);
        Countdown[1].SetActive(true);
        yield return new WaitForSeconds(beat);
        Countdown[1].SetActive(false);
        Countdown[2].SetActive(true);
        yield return new WaitForSeconds(beat);
        Countdown[2].SetActive(false);
        Debug.Log("HoldMove");

        Kari[1].SetActive(true);
        yield return new WaitForSeconds(5);
        Kari[1].SetActive(false);

        yield return StartCoroutine("TutorialSlideMsg");
    }
    
    IEnumerator TutorialSlideMsg()
    {
        Debug.Log("SlideMsg");
        for(float i = 0f;i<1;i+= 0.1f)
        {
            BackGround[2].GetComponent<Image>().color = new Color(255,255,255,i);
            Msgs[6].GetComponent<Text>().color = new Color(255,255,255,i);
            yield return null;
        }
        yield return new WaitForSeconds(3);
        for(float i = 1f;i>=-0.05f;i-= 0.05f)
        {
            BackGround[2].GetComponent<Image>().color = new Color(255,255,255,i);
            Msgs[6].GetComponent<Text>().color = new Color(255,255,255,i);
            yield return null;
        }
        Msgs[6].SetActive(false);
        yield return StartCoroutine("TutorialSlideMove");
    }
    
    IEnumerator TutorialSlideMove()
    {
        Countdown[0].SetActive(true);
        yield return new WaitForSeconds(beat);
        Countdown[0].SetActive(false);
        Countdown[1].SetActive(true);
        yield return new WaitForSeconds(beat);
        Countdown[1].SetActive(false);
        Countdown[2].SetActive(true);
        yield return new WaitForSeconds(beat);
        Countdown[2].SetActive(false);
        Debug.Log("SlideMove");

        Kari[2].SetActive(true);
        yield return new WaitForSeconds(5);
        Kari[2].SetActive(false);

        yield return StartCoroutine("TutorialLinkMsg");
    }

    IEnumerator TutorialLinkMsg()
    {
        Debug.Log("LinkMsg");
        for(float i = 0f;i<1;i+= 0.1f)
        {
            BackGround[2].GetComponent<Image>().color = new Color(255,255,255,i);
            Msgs[7].GetComponent<Text>().color = new Color(255,255,255,i);
            yield return null;
        }
        yield return new WaitForSeconds(3);
        for(float i = 1f;i>=-0.05f;i-= 0.05f)
        {
            BackGround[2].GetComponent<Image>().color = new Color(255,255,255,i);
            Msgs[7].GetComponent<Text>().color = new Color(255,255,255,i);
            yield return null;
        }
        Msgs[7].SetActive(false);
        yield return StartCoroutine("TutorialLinkMove");
    }
    
    IEnumerator TutorialLinkMove()
    {
        Countdown[0].SetActive(true);
        yield return new WaitForSeconds(beat);
        Countdown[0].SetActive(false);
        Countdown[1].SetActive(true);
        yield return new WaitForSeconds(beat);
        Countdown[1].SetActive(false);
        Countdown[2].SetActive(true);
        yield return new WaitForSeconds(beat);
        Countdown[2].SetActive(false);
        Debug.Log("LinkMove");

        Kari[3].SetActive(true);
        yield return new WaitForSeconds(5);
        Kari[3].SetActive(false);

        yield return StartCoroutine("TutorialSkillMsg_1P");
    }
    
    IEnumerator TutorialSkillMsg_1P()
    {
        Debug.Log("SkillMsg");
        SkillMsg[0].SetActive(true);
        SkillMsg[1].SetActive(true);
        yield return new WaitForSeconds(3);
        SkillMsg[0].SetActive(false);
        SkillMsg[1].SetActive(false);
        yield return StartCoroutine("TutorialSkill1Use_1P");
    }
    
    IEnumerator TutorialSkill1Use_1P()
    {
        Debug.Log("Skill1");
        Kari[4].SetActive(true);
        yield return new WaitForSeconds(5);
        Kari[4].SetActive(false);
        yield return StartCoroutine("TutorialSkill2Use_1P"); 
    }
    
    IEnumerator TutorialSkill2Use_1P()
    {
        Debug.Log("Skill2");
        Kari[5].SetActive(true);
        yield return new WaitForSeconds(5);
        Kari[5].SetActive(false);
        yield return StartCoroutine("TutorialSkillMsg_2P"); 
    }
    
    IEnumerator TutorialSkillMsg_2P()
    {
        Debug.Log("SkillMsg");
        SkillMsg[0].SetActive(true);
        SkillMsg[1].SetActive(true);
        yield return new WaitForSeconds(3);
        SkillMsg[0].SetActive(false);
        SkillMsg[1].SetActive(false);
        yield return StartCoroutine("TutorialSkill1Use_2P");
    }
    
    IEnumerator TutorialSkill1Use_2P()
    {
        Debug.Log("Skill1");
        Kari[4].SetActive(true);
        yield return new WaitForSeconds(5);
        Kari[4].SetActive(false);
        yield return StartCoroutine("TutorialSkill2Use_2P"); 
    }
    
    IEnumerator TutorialSkill2Use_2P()
    {
        Debug.Log("Skill2");
        Kari[5].SetActive(true);
        yield return new WaitForSeconds(5);
        Kari[5].SetActive(false);
        yield return StartCoroutine("TutorialEndMsg"); 
    }
    
    IEnumerator TutorialEndMsg()
    {
        for(float i = 0f;i<1;i+= 0.1f)
        {
            BackGround[2].GetComponent<Image>().color = new Color(255,255,255,i);
            Msgs[8].GetComponent<Text>().color = new Color(255,255,255,i);
            yield return null;
        }
        yield return new WaitForSeconds(3);
        for(float i = 1f;i>=-0.05f;i-= 0.05f)
        {
            BackGround[2].GetComponent<Image>().color = new Color(255,255,255,i);
            Msgs[8].GetComponent<Text>().color = new Color(255,255,255,i);
            yield return null;
        }
        Msgs[8].SetActive(false);
        yield return null;  
    }
}
