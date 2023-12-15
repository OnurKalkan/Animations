using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamAnim : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CamAnimator());
    }

    IEnumerator CamAnimator()
    {
        transform.DOMove(new Vector3(10, 1, 0), 2).SetEase(Ease.Linear);
        transform.DORotate(new Vector3(0, 270, 0), 2).SetEase(Ease.Linear);
        yield return new WaitForSeconds(2);

        transform.DOMove(new Vector3(0, 1, 10), 2).SetEase(Ease.Linear);
        transform.DORotate(new Vector3(0, 180, 0), 2).SetEase(Ease.Linear);
        yield return new WaitForSeconds(2);

        transform.DOMove(new Vector3(-10, 1, 0), 2).SetEase(Ease.Linear);
        transform.DORotate(new Vector3(0, 90, 0), 2).SetEase(Ease.Linear);
        yield return new WaitForSeconds(2);

        transform.DOMove(new Vector3(0, 1, -10), 2).SetEase(Ease.Linear);
        transform.DORotate(new Vector3(0, 00, 0), 2).SetEase(Ease.Linear);
        yield return new WaitForSeconds(2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
