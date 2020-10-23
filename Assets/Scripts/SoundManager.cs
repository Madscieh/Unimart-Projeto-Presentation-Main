using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip CaixaArrastando, CaixaQuebrando, PortaAbrindo, PortaDestrancando, Chave, AcerteiAlgo, TomeiDano, Oculos;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        CaixaArrastando = Resources.Load<AudioClip>("arrastandocaixa");
        CaixaQuebrando = Resources.Load<AudioClip>("caixamadeiraquebrando");
        PortaAbrindo = Resources.Load<AudioClip>("portaabrindo");
        PortaDestrancando = Resources.Load<AudioClip>("portadestrancando");
        Chave = Resources.Load<AudioClip>("key");
        AcerteiAlgo = Resources.Load<AudioClip>("AcerteiAlgo");
        TomeiDano = Resources.Load<AudioClip>("TomeiDano");
        Oculos = Resources.Load<AudioClip>("Oculos");

        audioSrc = GetComponent<AudioSource>();
    }

    public static void PlaySound (string clip)
    {
        switch (clip)
        {
            case "arrastandocaixa":
                audioSrc.PlayOneShot(CaixaArrastando);
                break;
            case "caixamadeiraquebrando":
                audioSrc.PlayOneShot(CaixaQuebrando);
                break;
            case "portaabrindo":
                audioSrc.PlayOneShot(PortaAbrindo);
                break;
            case "portadestrancando":
                audioSrc.PlayOneShot(PortaDestrancando);
                break;
            case "key":
                audioSrc.PlayOneShot(Chave);
                break;
            case "AcerteiAlgo":
                audioSrc.PlayOneShot(AcerteiAlgo);
                break;
            case "TomeiDano":
                audioSrc.PlayOneShot(TomeiDano);
                break;
            case "Oculos":
                audioSrc.PlayOneShot(Oculos);
                break;
        }
    }
}
