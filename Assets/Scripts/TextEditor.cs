using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TextEditor : MonoBehaviour
{
    private int _exp;
    private Text _expText;
    private void Start()
    {
        FindObjectOfType<Player>().OnPlayerPutExp += PlayerExpUpdate;
        _expText = GetComponent<Text>();
    }

    private void PlayerExpUpdate()
    {
        _exp++;
        _expText.text = _exp.ToString();
    }
}
