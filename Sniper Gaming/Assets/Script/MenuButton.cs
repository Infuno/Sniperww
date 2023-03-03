using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    public Animator animator;
    public GameObject button;

    private void Start()
    {
        StartCoroutine(Voice());
    }
    public void Pressed()
    {
        animator.SetTrigger("IsPress");
        button.SetActive(false);
    }

    IEnumerator Voice()
    {
        yield return new WaitForSeconds(1f);
        FindObjectOfType<AudioManager>().PlaySound("Start");
    }

    public void GameScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }
    public void MenuScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
