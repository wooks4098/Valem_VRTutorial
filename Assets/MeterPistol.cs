using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class MeterPistol : MonoBehaviour
{

    public ParticleSystem particles;

    public LayerMask layerMask;
    public Transform shootSource;
    public float distance = 10;

    private bool rayActivate = false;

    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.activated.AddListener(x => StartShoot());
        grabInteractable.deactivated.AddListener(x => StopShoot());
    }
    private void Update()
    {
        if (rayActivate)
            RaycastCheck();
    }
    public void StartShoot()
    {
        particles.Play();
        rayActivate = true;
    }

    public void StopShoot()
    {
        particles.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
        rayActivate = false;

    }

    void RaycastCheck()
    {
        RaycastHit hit;
        bool hasHIt = Physics.Raycast(shootSource.position, shootSource.forward,
            out hit, distance, layerMask);

        if (hasHIt)
        {
            hit.transform.gameObject.SendMessage("Breadk",SendMessageOptions.DontRequireReceiver);
        }
    }

}
