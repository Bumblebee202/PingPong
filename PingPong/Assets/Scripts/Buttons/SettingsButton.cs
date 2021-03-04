using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsButton : MonoBehaviour
{
    public void Click() => SceneManager.LoadScene("Settings");
}
