using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour {

    GameManager gameManager;
    float maxSecondOnScreen = 2.5f;
    float currentSecondsOnScreen = 0;

	
	void Start ()
    {
        Init();
    }

    private void Init()
    {
        gameManager = FindObjectOfType<GameManager>().GetComponent<GameManager>();
        ResetCurrentSecondsOnScreen();
    }

    private void OnMouseDown()
    {
        gameManager.AddScore();
        ResetCurrentSecondsOnScreen();
        Hide();
    }

    private void Hide()
    {
        gameManager.HideMonster(gameObject);
    }

    public bool IsActive => gameObject.activeInHierarchy;
    bool OnScreenTimeUp => currentSecondsOnScreen < 0;

    private void FixedUpdate()
    {
        TryCountDownToHide();

    }

    private void TryCountDownToHide()
    {
        if (IsActive)
        {
            CountDownCurrentSecondsOnScreen();
        }
        if (OnScreenTimeUp)
        {
            ResetCurrentSecondsOnScreen();
            Hide();
        }
    }

    private void CountDownCurrentSecondsOnScreen()
    {
        currentSecondsOnScreen -= Time.fixedDeltaTime;
    }

    private void ResetCurrentSecondsOnScreen()
    {
        currentSecondsOnScreen = maxSecondOnScreen;
    }

    void Update () {
		
	}
}
