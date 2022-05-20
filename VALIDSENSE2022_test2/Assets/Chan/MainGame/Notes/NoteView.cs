using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteView : MonoBehaviour
{
    SpriteRenderer sprite;

    public float noteSpeed;

    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    public void NoteSpeedSetter(double speed)
    {
        noteSpeed = (float)speed;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position -= new Vector3 (0, noteSpeed, 0);
    }

    public void NoteFadeOut()
    {
        StartCoroutine(FadeOut());
    }

    IEnumerator FadeOut()
    {
        sprite.color = new Color(1.0f, 1.0f ,1.0f,0.8f);
        yield return new WaitForSeconds(0.03f);

        sprite.color = new Color(1.0f, 1.0f, 1.0f, 0.5f);
        yield return new WaitForSeconds(0.03f);

        sprite.color = new Color(1.0f, 1.0f, 1.0f, 0.2f);
        yield return new WaitForSeconds(0.02f);

        this.gameObject.SetActive(false);
    }
}
