using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class inputMoneyField : MonoBehaviour
{
    public GameObject tipoPagamento;
    public Text textoFinal;
    public InputField texto;
    public float valorOriginal = 0f;
    public calculateValue calculate;

    void Update()
    {
        textoFinal.text = calculate.EnviaValorFinal;
    }

    public void ShowValue()
    {
        string valueChanged = texto.text;

        if (texto.text == string.Empty || texto.text == "")
        {
            valueChanged = "0";
        }

        if (!valueChanged.Contains("R$ "))
        {
            valueChanged = "R$ " + valueChanged;
        }

        if (!valueChanged.Contains(","))
        {
            valueChanged += ",00";
        }
        else
        {
            if(valueChanged.Length - valueChanged.IndexOf(",") == 1)
            {
                valueChanged += "00";
            }
            else if (valueChanged.Length - valueChanged.IndexOf(",") == 2)
            {
                valueChanged += "0";
            }
        }

        texto.text = valueChanged;
    }

    public void GetOriginalValue()
    {
        string temporaria = texto.text;

        if (temporaria.Contains("R$ "))
        {
            temporaria = texto.text.Remove(0, 3);
        }
        
        if(temporaria.Contains(","))
        {
            temporaria = temporaria.Replace(",", ".");
        }

        valorOriginal = float.Parse(string.Format("{0:0.00}", temporaria));
        calculate.RecebeValorInicial = valorOriginal;
    }
}
