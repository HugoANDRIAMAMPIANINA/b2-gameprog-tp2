using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SetPlayerInvisible : MonoBehaviour
{
    private TextMeshProUGUI _isInvisibleText;
    private IEnumerator _coroutine;
    void Start()
    {
        _isInvisibleText = GameObject.Find("IsInvisibleText").GetComponent<TextMeshProUGUI>();
        _isInvisibleText.enabled = false;
        GetComponent<Renderer>().enabled = true;
        _coroutine = SetInvisible();
        StartCoroutine(_coroutine);
    }

    IEnumerator SetInvisible()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(10.0f, 30.0f));
            GetComponent<Renderer>().enabled = false;
            _isInvisibleText.enabled = true;
            
            yield return new WaitForSeconds(4.0f);
            GetComponent<Renderer>().enabled = true;
            _isInvisibleText.enabled = false;
        }
    }
}
