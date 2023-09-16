using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oyuncu_Kontrol : MonoBehaviour
{
    public AudioClip altin, dusme;
    public Oyun_control oyunk;
    private float hiz = 10f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (oyunk.OyunAktif)
        {
            float x = Input.GetAxis("Horizontal");
            float y = Input.GetAxis("Vertical");

            x *= Time.deltaTime * hiz;
            y *= Time.deltaTime * hiz;

            transform.Translate(x, 0f, y);
        }
    }
    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag.Equals ("altin"))
        {
            GetComponent<AudioSource>().PlayOneShot( altin, 1f);
            oyunk.AltinArttir ();
            Destroy(c.gameObject);


        }else if (c.gameObject.tag.Equals("Dusman"))
        {
            GetComponent<AudioSource>().PlayOneShot(dusme, 1f);
            oyunk.OyunAktif = false;
        }
    }
}
