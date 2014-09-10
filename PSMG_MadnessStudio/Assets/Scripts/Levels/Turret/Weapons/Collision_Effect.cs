﻿using UnityEngine;
using System.Collections;

public class Collision_Effect : MonoBehaviour {

    float EffectTime;

    void Update()
    {
        if (EffectTime > 0)
        {
            if (EffectTime < 450 && EffectTime > 400)
            {
                renderer.sharedMaterial.SetVector("_ShieldColor", new Vector4(0.7f, 1, 1, 0));
            }

            EffectTime -= Time.deltaTime * 1000;

            renderer.sharedMaterial.SetFloat("_EffectTime", EffectTime);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        foreach(ContactPoint contact in collision.contacts) {
 
        renderer.sharedMaterial.SetVector("_ShieldColor", new Vector4(0.7f, 1, 1, 0.05f));
 
        renderer.sharedMaterial.SetVector("_Position", transform.InverseTransformPoint(contact.point));
 
        EffectTime=500;
    }
    }
}
