using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class controlType : MonoBehaviour
{
    public Dropdown type;
    public calculateValue calculate;

    //Verifica o tipo de pagamento ativo
    public void CheckType()
    {
        //Instancia uma variável nomeada Juros
        float juros = 3.49f;

        //Se for a primeira opção
        if (type.value == 0)
        {
            //Seta que está selecionando o modo de crédito
            calculate.CreditoAtivo = true;
            //Aplica juros de 3.49% sobre o pagamento
            juros = 3.49f;
        }
        else
        {
            //Seta que está selecionando o modo de débito
            calculate.CreditoAtivo = false;
            //Aplica juros de 2.29% sobre o pagamento
            juros = 2.29f;
        }

        //Envia o juros relacionado ao pagamento
        calculate.RecebeJurosTipo = juros;
    }
}
