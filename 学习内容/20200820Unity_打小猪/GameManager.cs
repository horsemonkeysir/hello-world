using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class GameManager : MonoBehaviour {

    public float showMonsterIntervalSeconds = 2;
    public float countDownShowMonsterSeconds;
    int MAX_MONSTERS_ON_SCREEN = 3;

    public List<Monster> monsters;
    Text score;
    int scoreNumber=0;

    public void HideMonster(GameObject monster)
    {
        monster.SetActive(false);
    }

    void ShowMonster(GameObject monster)
    {
        monster.SetActive(true);
    }

    public void AddScore()
    {
        scoreNumber += 10;
        score.text = scoreNumber.ToString();
    }


	// Use this for initialization
	void Start ()
    {
        InitScore();
        InitMonsterList();
        HideAllMonsters();
        //ShowRandomMonster();
        ResetShowMonsterSeconds();
    }

    private void ResetShowMonsterSeconds()
    {
        countDownShowMonsterSeconds = showMonsterIntervalSeconds;
    }

    void HideAllMonsters()
    {
        foreach(var m in monsters)
        {
            HideMonster(m.gameObject);
        }
    }

    List<Monster> HiddenMonsters
    {
        get
        {
            var result = new List<Monster>();
            foreach (var m in monsters)
            {
                if (!m.IsActive)
                {
                    result.Add(m);
                }
            }
            return result;
        }
    }

    int MonsterCountOnScreen
    {
        get
        {
            int result=0;
            foreach (var m in monsters)
            {
                if (m.IsActive)
                {
                    result += 1;
                }
            }
            return result;
        }
    }

    void ShowRandomMonster()
    {
        int r = Random.Range(0,HiddenMonsters.Count);
        Monster m = HiddenMonsters[r];
        ShowMonster(m.gameObject);
    }

    private void InitMonsterList()
    {
        monsters = GameObject.FindObjectsOfType<Monster>().ToList();
    }

    private void InitScore()
    {
        score = GameObject.FindGameObjectWithTag("Score").GetComponent<Text>();
        score.text = "";
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        TryCountDowToShowMonster();
    }

    bool CountDownShowMonsterTimeUp => countDownShowMonsterSeconds <= 0;
    bool MonstersOnScreenAreFull => MonsterCountOnScreen >= MAX_MONSTERS_ON_SCREEN;

    private void TryCountDowToShowMonster()
    {
        countDownShowMonsterSeconds -= Time.fixedDeltaTime;
        if (CountDownShowMonsterTimeUp)
        {
            ResetShowMonsterSeconds();

            if (!MonstersOnScreenAreFull)
            {
                ShowRandomMonster();
            }
        }
    }
}
