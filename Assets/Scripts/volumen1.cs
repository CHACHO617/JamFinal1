using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class volumen1 : MonoBehaviour
{
    public AudioMixer audioMixer;
    // Start is called before the first frame update
    public void CambiarVolumen(float volumen)
    {
        audioMixer.SetFloat("Volumen", volumen);
    }
}
