using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    public UnityAction OnPlayerPutExp;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out Exp exp))
        {
            OnPlayerPutExp.Invoke();
            Destroy(exp.gameObject);
        }
    }
}
