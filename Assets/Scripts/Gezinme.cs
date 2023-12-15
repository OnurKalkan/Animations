using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Gezinme : MonoBehaviour
{
    public GameObject pos1, pos2;
    // Start is called before the first frame update
    void Start()
    {
        transform.DOMove(pos2.transform.position, 2).OnComplete(GoTarget1).SetDelay(1).SetEase(Ease.Linear);
        Camera.main.fieldOfView = 30;
    }

    void GoTarget1()
    {
        transform.DOMove(pos1.transform.position, 3).OnComplete(GoTarget2).SetDelay(1).SetEase(Ease.Linear);
        transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        Camera.main.fieldOfView = 40;
    }

    void GoTarget2()
    {
        transform.DOMove(pos2.transform.position, 3).OnComplete(GoTarget1).SetDelay(1).SetEase(Ease.Linear);
        transform.localScale = new Vector3(-0.1f, 0.1f, 0.1f);
        Camera.main.fieldOfView = 50;
    }

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if(collision.tag == "Target 1")
    //    {
    //        transform.DOMove(pos2.transform.position, 2);
    //    }
    //    if (collision.tag == "Target 2")
    //    {
    //        transform.DOMove(pos1.transform.position, 2);
    //    }
    //}
}
