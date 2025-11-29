using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void Jogar()
    {
        SceneManager.LoadScene("SelecaoProjeto");
    }

    public void Instrucoes()
    {
        SceneManager.LoadScene("Instruções");
    }

    public void SairJogo()
    {
        Application.Quit();
    }
}
