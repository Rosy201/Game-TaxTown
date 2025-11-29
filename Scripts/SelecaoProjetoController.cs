using UnityEngine;
using UnityEngine.SceneManagement;

public class SelecaoProjetoController : MonoBehaviour
{
    public static string projetoAtual;

    public void SelecionarHospital()
    {
        projetoAtual = "Hospital";
        SceneManager.LoadScene("CenaHospital");
    }

    public void SelecionarEscola()
    {
        projetoAtual = "Escola";
        SceneManager.LoadScene("CenaEscola");
    }

    public void SelecionarRua()
    {
        projetoAtual = "Rua";
        SceneManager.LoadScene("CenaRua");
    }

    public void VoltarMenu()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }

}
