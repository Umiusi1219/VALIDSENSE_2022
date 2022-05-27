using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hear_AnimeTest : MonoBehaviour
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
                animator.Play("win 2_anim");
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                animator.Play("choice_anim");
            }
            else if (Input.GetKeyDown(KeyCode.F))
            {
                animator.Play("choice_anim");
            }
        }
        else if (Input.GetKey(KeyCode.A))
        {

            if (Input.GetKeyDown(KeyCode.S))
            {
                animator.Play("att_anim_hear");
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                animator.Play("hit_anim");
            }
            else if (Input.GetKeyDown(KeyCode.F))
            {
                animator.Play("hit_anim");
            }
        }
    }
}
