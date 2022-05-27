using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tactile_AnimeTest : MonoBehaviour
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
            else if (Input.GetKeyDown(KeyCode.D))
            {
                animator.Play("choiceB_anim");
            }
            else if (Input.GetKeyDown(KeyCode.F))
            {
                animator.Play("choiceC_anim");
            }
        }
        else if (Input.GetKey(KeyCode.A))
        {

            if (Input.GetKeyDown(KeyCode.S))
            {
                animator.Play("attA_anim");
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                animator.Play("hit_anim");
            }
            else if (Input.GetKeyDown(KeyCode.F))
            {
                animator.Play("hit2_anim");
            }
        }
    }
}
