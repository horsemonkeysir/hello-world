using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public InputField playerAnswerUI;
    public int playerAnswer;
    public int correctAnswer;
    public Text hintMessage;
    public Button restartButton;
    public AudioSource Congratulations;
    public AudioSource WrongSound;
    public AudioSource Continue;

    void Start () {
        
        NewQuestion();
    }
	
    void UpdateHintMessage(string message)
    {
        hintMessage.text = message;
    }
    
    void NewQuestion()
    {
        UpdateHintMessage("请输入0~99之间的数字");
        correctAnswer = Random.Range(0, 100);
        restartButton.gameObject.SetActive(false);
    }

    bool CanGetInputNumber()
    {
        return int.TryParse(playerAnswerUI.text, out playerAnswer);
    }

    public void CompareNumbers(){
        if (!CanGetInputNumber())
        {
            UpdateHintMessage("只能输入数字喔~");
            WrongSound.Play();
            return;
        }

        if (playerAnswer==correctAnswer)
        {
            UpdateHintMessage("恭喜你答对了!");
            Congratulations.Play();
            restartButton.gameObject.SetActive(true);
            //暂时不知道怎么取消掉点击"重新开始"的庆祝音效
        }


        if (playerAnswer > correctAnswer)
        {
            UpdateHintMessage("答案还要再小一点");
            Continue.Play();
        }

        if (playerAnswer < correctAnswer)
        {
            UpdateHintMessage("答案还要再大一点");
            Continue.Play();
        }

        FocusPlayAnswerUI();
    }

    public void ClearHintMessage()
    {
        UpdateHintMessage("");
    }

    public void ReloadScene()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }

    void FocusPlayAnswerUI()
    {
        playerAnswerUI.ActivateInputField();
    }

	void Update () {
		
	}
}
