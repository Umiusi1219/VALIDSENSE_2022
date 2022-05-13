using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteView : MonoBehaviour
{
    public float noteSpeed;
    
    public void NoteSpeedSetter(double speed)
    {
        noteSpeed = (float)speed;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position -= new Vector3 (0, noteSpeed, 0);
    }
}
