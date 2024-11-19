using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashCan : MonoBehaviour
{

    private void Start()
    {
        //TriggerZone�� �̺�Ʈ ���
        GetComponent<TriggerZone>().OnEnterEvent.AddListener(InsideTrash);
    }

    //�������� �ȿ� ���� ������Ʈ ����
    public void InsideTrash(GameObject go)
    {
        go.SetActive(false);
    }
}
