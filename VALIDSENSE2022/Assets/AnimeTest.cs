using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimeTest : MonoBehaviour
{

    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                animator.Play("win_anim");
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {

            }
            else if (Input.GetKeyDown(KeyCode.A))
            {

            }
        }
        else if(Input.GetKey(KeyCode.A))
        {

        }
    }
}
