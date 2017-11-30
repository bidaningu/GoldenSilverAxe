using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class DialogueSelect : MonoBehaviour
{
    private bool isTouched = false;
    private Vector3 scaleVector = new Vector3(1.5f, 1.5f, 1.5f);
    private Vector3 originVector = new Vector3(1, 1, 1);
    public PlayableDirector pd;

    private void Update()
    {
        if (isTouched)
        {
            transform.localScale = scaleVector;
            if (Input.GetAxis("Fire2") > 0.1f)
            {
                Debug.Log("클릭");
                Debug.Log(pd.name);
                if (pd.name.Equals("DirectorGoldSilver"))
                {
                    GameManager.ChangeAxeSel(1);
                }
                else if (pd.name.Equals("DirectorIron"))
                {
                    GameManager.ChangeAxeSel(2);
                }
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