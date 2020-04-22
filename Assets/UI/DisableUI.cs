using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisableUI : MonoBehaviour
{
    public GameObject levelIntro;

    IEnumerator waitTimer()
    {
        yield return new WaitForSeconds(3f);
    }

    IEnumerator Start()
    {
        yield return StartCoroutine(waitTimer());
        levelIntro.SetActive(false);
    }
    

   
}
