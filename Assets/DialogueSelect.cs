using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class DialogueSelect : MonoBehaviour
{
    public bool isTouched = false;
    private Vector3 scaleVector = new Vector3(1.5f, 1.5f, 1.5f);
    private Vector3 originVector = new Vector3(1, 1, 1);
    public GameObject pd;

    private void Update()
    {
        if (Input.GetAxis("Fire2") > 0.1f)
        {
            Debug.Log("클릭");
            if (isTouched)
            {
                pd.SetActive(true);
            }
        }

        if (isTouched)
        {
            transform.localScale = scaleVector;
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