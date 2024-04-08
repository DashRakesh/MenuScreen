using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour
{
    public GameObject loadingScreen;
    public Slider loadingSlider;
    public Text progressText;

  public void LoadLevel(int sceneIndex)
    {
        StartCoroutine(LoadSyncroniously(sceneIndex));  
    }

    IEnumerator LoadSyncroniously(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        loadingScreen.SetActive(true);

        while(!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            loadingSlider.value = progress;

            progressText.text = progress * 100f + "%";

            yield return null;
        }
    }
}
