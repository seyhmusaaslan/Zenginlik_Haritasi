using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamera_Control : MonoBehaviour
{
    public Oyun_control oyunk;
    float hassasiyet = 5f;
    float yumusaklýk = 2f;

    Vector2 gecýsPos;
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
            farePos = Vector2.Scale(farePos, new Vector2(hassasiyet * yumusaklýk, hassasiyet * yumusaklýk));
            gecýsPos.x = Mathf.Lerp(gecýsPos.x, farePos.x, 1f / yumusaklýk);
            gecýsPos.y = Mathf.Lerp(gecýsPos.y, farePos.y, 1f / yumusaklýk);
            camPos += gecýsPos;

            transform.localRotation = Quaternion.AngleAxis(-camPos.y, Vector3.right);
            oyuncu.transform.localRotation = Quaternion.AngleAxis(camPos.x, oyuncu.transform.up);
        }

    }
}
