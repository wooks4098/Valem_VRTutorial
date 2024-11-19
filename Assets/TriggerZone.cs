using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerZone : MonoBehaviour
{
    public string targetTag;
    public UnityEvent<GameObject> OnEnterEvent;
    private void OnTriggerEnter(Collider other)
    {
        //"targetTag"트리거 발동시 이벤트 발생
        if (other.gameObject.tag == targetTag)
        {
            OnEnterEvent.Invoke(other.gameObject);
        }
    }
}
