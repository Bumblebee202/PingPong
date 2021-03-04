using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public void Click() => SceneManager.LoadScene("Game");
}
