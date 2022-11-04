using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    public Animator animator;
    private int levelToLoad;

    void Update()
    {
        if (LogicaNPC.check4 == true)
        {
            FadeToLevel(1);
        }

        if (CountDownTimer.timesUp == true)
        {
            CountDownTimer.timesUp = false;
            FadeToLevel(2);
        }

        if (btnReload.checkFade == true)
        {
            FadeToLevel(0);
            btnReload.checkFade = false;
        }
    }

    public void FadeToLevel (int levelIndex)
    {   
        levelToLoad = levelIndex;
        animator.SetTrigger("FadeOut");
    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene(levelToLoad);
    }
}
