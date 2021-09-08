using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bailaController : MonoBehaviour
{
    public Animator animController;
    public AudioSource audioPersonaje;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            animController.SetBool("baila",true);
        }
        if (animController.GetCurrentAnimatorClipInfo(0)[0].clip.name=="Macarena Dance"||animController.GetCurrentAnimatorClipInfo(0)[0].clip.name=="Thriller Part 4"||animController.GetCurrentAnimatorClipInfo(0)[0].clip.name=="Breakdance Ending 2"||animController.GetCurrentAnimatorClipInfo(0)[0].clip.name=="Samba Dancing")
        {
            animController.SetBool("baila",false);
            if (!audioPersonaje.isPlaying)
            {
                audioPersonaje.Play();
            }
        }

        if (animController.GetCurrentAnimatorClipInfo(0)[0].clip.name=="idle"||animController.GetCurrentAnimatorClipInfo(0)[0].clip.name=="Old Man Idle"
        ||animController.GetCurrentAnimatorClipInfo(0)[0].clip.name=="Idle"
        ||animController.GetCurrentAnimatorClipInfo(0)[0].clip.name=="Breathing Idle")
        {
            audioPersonaje.Pause();
        }
    }
}
