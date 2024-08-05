using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour
{
    public GameObject clearText;
    private void OnTriggerEnter(Collider other)
    {
        DestroySelf();
        IsCleard(); // クリア
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Stay");
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Exit");
    }

    private void DestroySelf()
    {
        Destroy(gameObject);
    }
    private void IsCleard()
    {
        // ClearText表示
        clearText.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        // 初期状態ではclearTextを非表示
        if (clearText != null)
        {
            clearText.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
