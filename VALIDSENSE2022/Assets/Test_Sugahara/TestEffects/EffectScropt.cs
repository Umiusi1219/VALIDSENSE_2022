using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectScropt : MonoBehaviour
{
    SpriteRenderer sprite;

    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();

        StartCoroutine(FadeOut());
    }

    IEnumerator FadeOut()
    {
        sprite.color = new Color(1.0f, 1.0f, 1.0f, 0.8f);
        transform.position += new Vector3(0f, 0.5f, 0f);
        yield return new WaitForSeconds(0.1f);

        sprite.color = new Color(1.0f, 1.0f, 1.0f, 0.5f);
        transform.position += new Vector3(0f, 0f, 0f);
        yield return new WaitForSeconds(0.08f);

        sprite.color = new Color(1.0f, 1.0f, 1.0f, 0.2f);
        transform.position += new Vector3(0f, 0.5f, 0f);
        yield return new WaitForSeconds(0.07f);

        this.gameObject.SetActive(false);
    }
}
