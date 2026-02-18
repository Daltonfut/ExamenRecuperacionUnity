
using TMPro;
using UnityEngine;

public class puntos : MonoBehaviour
{
    public static puntos instance; 
    public TMP_Text textoPuntos;
    private int Puntos;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        Puntos = 0;
        textoPuntos.text = "0";
    }
    public void SumaPuntos()
    {
        Puntos++;
        textoPuntos.text = Puntos.ToString();
    }
}