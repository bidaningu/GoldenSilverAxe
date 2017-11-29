using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class DialogueSelect : MonoBehaviour
{
    private bool isTouched = false;
    private Vector3 scaleVector = new Vector3(2, 2, 2);
    private Vector3 originVector = new Vector3(1, 1, 1);
    public PlayableDirector pd;

    private void Update()
    {
        if (isTouched)
        {
            transform.localScale = scaleVector;
            if (Input.GetButtonDown("Fire2"))
            {
                pd.Play();
            }
        }
        else
        {
            transform.localScale = originVector;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        isTouched = true;
    }

    private void OnTriggerExit(Collider other)
    {
        isTouched = false;
    }
}