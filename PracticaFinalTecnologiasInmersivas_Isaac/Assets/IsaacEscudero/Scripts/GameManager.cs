using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] TMP_Text contadorText;
    [SerializeField] TMP_Text winText;
    public static GameManager instance;

    public int contador = 0;
    [SerializeField]float winMax = 10;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else 
        {
            Destroy(this.gameObject);
        }
        winText.gameObject.SetActive(false);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        contadorText.text = contador.ToString();
    }
    public void SumCounter()
    {
        contador++;
        contadorText.text = contador.ToString();
        if (contador >= winMax)
        {
            winText.gameObject.SetActive(true);
        }
    }
}
