using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class controlParcelas : MonoBehaviour
{
    public Dropdown parcelas;
    public calculateValue calculate;

	public void ModificaJuros()
    {
        float juros = 0f;

        switch (parcelas.value)
        {
            case 0:
                {
                    juros = 0f;
                    break;
                }
            case 1:
                {
                    juros = 1.99f;
                    break;
                }
            case 2:
                {
                    juros = 3.99f;
                    break;
                }
            case 3:
                {
                    juros = 4.49f;
                    break;
                }
            case 4:
                {
                    juros = 6.99f;
                    break;
                }
            case 5:
                {
                    juros = 8.49f;
                    break;
                }
            case 6:
                {
                    juros = 9.99f;
                    break;
                }
            case 7:
                {
                    juros = 11.49f;
                    break;
                }
            case 8:
                {
                    juros = 12.99f;
                    break;
                }
            case 9:
                {
                    juros = 13.99f;
                    break;
                }
            case 10:
                {
                    juros = 15.29f;
                    break;
                }
            case 11:
                {
                    juros = 16.49f;
                    break;
                }
        }

        calculate.RecebeJurosParcelas = juros;
    }
}
