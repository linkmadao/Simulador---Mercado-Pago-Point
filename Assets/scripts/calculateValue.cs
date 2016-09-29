using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class calculateValue : MonoBehaviour
{
    public GameObject parcelas;
    private float jurosTipo = 3.49f, jurosParcelas = 0f, valorInicial = 0f, total = 0f;
    private bool creditoAtivo = true;
    private string textoFinal = "";

	// Update is called once per frame
	void Update ()
    {
        //Se o objeto parcelas estiver ativo e a variavel creditoAtivo estiver desativada, ele irá desativar. E vice e versa
        if(parcelas.activeSelf != creditoAtivo)
        {
            //Altera o estado do gameObject
            parcelas.SetActive(creditoAtivo);
        }

        //Se o crédito tiver ativo
        if (creditoAtivo)
        {
            total = valorInicial + (valorInicial * (jurosParcelas / 100));
            total += (total * (jurosTipo / 100));
        }
        //Senão
        else
        {
            total = valorInicial + (valorInicial * (jurosTipo / 100));
        }

        string textoTotal = "R$ " + string.Format("{0:0,00}", total.ToString("F2"));
        textoFinal = textoTotal;
        textoFinal = textoFinal.Replace(".", ",");
    }

    public float RecebeValorInicial
    {
        set
        {
            valorInicial = value;
        }
    }

    public string EnviaValorFinal
    {
        get
        {
            return textoFinal;
        }
    }

    public bool CreditoAtivo
    {
        set
        {
            creditoAtivo = value;
        }
    }

    public float RecebeJurosTipo
    {
        set
        {
            jurosTipo = value;
        }
    }

    public float RecebeJurosParcelas
    {
        set
        {
            jurosParcelas = value;
        }
    }
}
