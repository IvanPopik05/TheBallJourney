using UnityEngine;
using UnityEngine.SceneManagement;

namespace DefaultNamespace
{
    public class WinPanel : MonoBehaviour
    {
        public void NextLevel() => 
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}