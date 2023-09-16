using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamera_Control : MonoBehaviour
{
    public Oyun_control oyunk;
    float hassasiyet = 5f;
    float yumusakl�k = 2f;

    Vector2 gec�sPos;
    Vector2 camPos;

    GameObject oyuncu;
 
    void Start()
    {
        oyuncu = transform.parent.gameObject;
        camPos.y = 12f;

    }

   
    void Update()
    {
        if (oyunk.OyunAktif)
        {
            Vector2 farePos = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
            farePos = Vector2.Scale(farePos, new Vector2(hassasiyet * yumusakl�k, hassasiyet * yumusakl�k));
            gec�sPos.x = Mathf.Lerp(gec�sPos.x, farePos.x, 1f / yumusakl�k);
            gec�sPos.y = Mathf.Lerp(gec�sPos.y, farePos.y, 1f / yumusakl�k);
            camPos += gec�sPos;

            transform.localRotation = Quaternion.AngleAxis(-camPos.y, Vector3.right);
            oyuncu.transform.localRotation = Quaternion.AngleAxis(camPos.x, oyuncu.transform.up);
        }

    }
}
