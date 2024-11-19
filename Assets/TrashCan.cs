using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashCan : MonoBehaviour
{

    private void Start()
    {
        //TriggerZone에 이벤트 등록
        GetComponent<TriggerZone>().OnEnterEvent.AddListener(InsideTrash);
    }

    //쓰레기통 안에 들어온 오브젝트 끄기
    public void InsideTrash(GameObject go)
    {
        go.SetActive(false);
    }
}
