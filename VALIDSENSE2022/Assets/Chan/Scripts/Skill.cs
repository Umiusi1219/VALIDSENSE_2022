using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skill : MonoBehaviour
{
    public static float SkillGauge1P;
    public static float SkillGauge2P;
    private float SkillPercent = 100;
    [SerializeField]public GameObject[] SkillGauge;
    [SerializeField]public GameObject[] SkillSight;

    public enum skillType1P
    {
        Sight = 1,
        Tactile,
        SmaillTaste,
        Hear
    }
    public enum skillType2P
    {
        Sight = 1,
        Tactile,
        SmaillTaste,
        Hear
    }
    // Start is called before the first frame update
    void Start()
    {
        SkillGauge1P = 100;
        SkillGauge2P = 100;
    }

    // Update is called once per frame
    void Update()
    {
        Skillbar();
    }

    private void Skillbar()
    {
        SkillGauge[0].GetComponent<RectTransform>().localScale = new Vector3 (SkillGauge1P/SkillPercent,1,1);
        SkillGauge[1].GetComponent<RectTransform>().localScale = new Vector3 (SkillGauge2P/SkillPercent,1,1);
        if(SkillGauge1P>=100)
        {
            StartCoroutine(SkillbarMax(0));
            if(Input.GetKeyDown(KeyCode.A))
            {
                SkillGauge1P = 0; 
                StartCoroutine(SightSkill1P());
            }
        }
        if(SkillGauge2P>=100)
        {
            StartCoroutine(SkillbarMax(1));
            if(Input.GetKeyDown(KeyCode.J))
            {
                SkillGauge2P = 0; 
                StartCoroutine(SightSkill2P());
            }
        }
    }
    IEnumerator SkillbarMax(int playernum)
    {
        
        while(true)
        {
            SkillGauge[playernum].GetComponent<Image>().color = new Color(255,255,255,255);
            yield return new WaitForSeconds(0.2f);
            SkillGauge[playernum].GetComponent<Image>().color = new Color(255,0,0,255);
            yield return new WaitForSeconds(0.2f);
            SkillGauge[playernum].GetComponent<Image>().color = new Color(0,255,0,255);
            yield return new WaitForSeconds(0.2f);
            SkillGauge[playernum].GetComponent<Image>().color = new Color(0,0,255,255);
            yield return new WaitForSeconds(0.2f);
        }
    }
    IEnumerator SightSkill1P() //スキルサイト1P
    {
        var localPos = SkillSight[0].GetComponent<RectTransform>().position;
        var endPos = new Vector3(1440,960,0);
        Debug.Log("1P");
        for(float i = 0f;i<1.1f;i+= 0.1f)
        {
            SkillSight[0].GetComponent<RectTransform>().position = Vector3.Lerp(localPos,endPos,i);
            yield return null;
        }
        yield return new WaitForSeconds(0.5f);
        Debug.Log("Back");
        for(float i = 1f;i>-0.1f;i-= 0.1f)
        {
            SkillSight[0].GetComponent<RectTransform>().position = Vector3.Lerp(localPos,endPos,i);
            yield return null;
        }
    }
    IEnumerator SightSkill2P()  //スキルサイト2P
    {
        var localPos = SkillSight[1].GetComponent<RectTransform>().position;
        var endPos = new Vector3(480,960,0);
        Debug.Log("2P");
        for(float i = 0f;i<1.1f;i+= 0.1f)
        {
            SkillSight[1].GetComponent<RectTransform>().position = Vector3.Lerp(localPos,endPos,i);
            yield return null;
        }
        yield return new WaitForSeconds(0.5f);
        Debug.Log("Back");
        for(float i = 1f;i>-0.1f;i-= 0.1f)
        {
            SkillSight[1].GetComponent<RectTransform>().position = Vector3.Lerp(localPos,endPos,i);
            yield return null;
        }
        

    }
    IEnumerator Tactile1P()    //スキルタクタイル1P 
    {
        yield return null;
    }
    IEnumerator Tactile2P()    //スキルタクタイル2P 
    {
        yield return null;
    }
}
