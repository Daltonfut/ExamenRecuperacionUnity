using UnityEngine;
using TMPro;

public class vida : MonoBehaviour
{
    public static vida instance; 
    public TMP_Text textoVidas;
    public int vidas;
    private void Awake()
    {
        instance = this; 
    }
    void Start()
    {
        vidas = 2;
        textoVidas.text = "2";
    }

    public void quitaVida()
    {
        vidas--;
        textoVidas.text = vidas.ToString();
    }
}
