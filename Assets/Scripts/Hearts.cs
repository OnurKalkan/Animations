using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Hearts : MonoBehaviour
{
    public GameObject gameOverPanel, heartPanel;
    private void Start()
    {
        gameOverPanel.SetActive(false);
        heartPanel.SetActive(true);
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
            HeartLost();
    }

    IEnumerator CloseHeart(int x)
    {
        transform.GetChild(x).DOShakePosition(1.0f, 25, 25);
        yield return new WaitForSeconds(1);
        transform.GetChild(x).gameObject.SetActive(false);
        bool anyHeartLeft = false;
        for (int i = 0; i < transform.childCount; i++)
        {
            if(transform.GetChild(i).gameObject.activeInHierarchy == true)
                anyHeartLeft = true;
        }
        if (anyHeartLeft == false)
        {
            gameOverPanel.SetActive(true);
            heartPanel.SetActive(false);
        }
    }

    void HeartLost()
    {
        int x = 0;
        for (int i = 3; i >= 0; i--)
        {
            if(transform.GetChild(i).gameObject.activeInHierarchy == true)
            {                
                StartCoroutine(CloseHeart(i));
                break;
            }
        }
    }
}
