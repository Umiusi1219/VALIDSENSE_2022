using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineOverMaterialScript : MonoBehaviour
{
    [SerializeField]
    private int lineNum;

    MeshRenderer mesh;

    private void Start()
    {
        mesh = GetComponent<MeshRenderer>();
    }



    // Update is called once per frame
    void Update()
    {
        switch(lineNum)
        {
            case 0:

                if (Input.GetKeyDown(KeyCode.R))
                {
                    mesh.material.color = new Color32(255, 255, 255, 22);

                }
                else if(Input.GetKey(KeyCode.R))
                {

                    mesh.material.color = new Color32(255, 255, 255, 47);
                }
                else if(Input.GetKeyUp(KeyCode.R))
                {

                    StartCoroutine(FadeOut());
                }
                break;

            case 1:
                if (Input.GetKeyDown(KeyCode.E))
                {
                    mesh.material.color = new Color32(255, 255, 255, 22);

                }
                else if (Input.GetKey(KeyCode.E))
                {

                    mesh.material.color = new Color32(255, 255, 255, 47);
                }
                else if (Input.GetKeyUp(KeyCode.E))
                {

                    StartCoroutine(FadeOut());
                }
                break;

            case 2:
                if (Input.GetKeyDown(KeyCode.W))
                {
                    mesh.material.color = new Color32(255, 255, 255, 22);

                }
                else if (Input.GetKey(KeyCode.W))
                {

                    mesh.material.color = new Color32(255, 255, 255, 47);
                }
                else if (Input.GetKeyUp(KeyCode.W))
                {

                    StartCoroutine(FadeOut());
                }
                break;

            case 3:
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    mesh.material.color = new Color32(255, 255, 255, 22);

                }
                else if (Input.GetKey(KeyCode.Q))
                {

                    mesh.material.color = new Color32(255, 255, 255, 47);
                }
                else if (Input.GetKeyUp(KeyCode.Q))
                {

                    StartCoroutine(FadeOut());
                }
                break;

            default:
                return;
                    
        }

    }


    IEnumerator FadeOut()
    {

        mesh.material.color = new Color32(255, 255, 255, 22);

        yield return new WaitForSeconds(0.05f);

        mesh.material.color = new Color32(255, 255, 255, 0);

    }
}
