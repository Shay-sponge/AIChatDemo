using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime;
using UnityEngine;
using UnityEngine.UI;

public class TutorialUI : MonoBehaviour
{
    //private Image image;

    [SerializeField] Sprite[] sprites;
    private int index;

    [SerializeField] GameObject tutorialUI;

    private void Start()
    {
       // image = GetComponent<Image>();
    }

    public void ChangeSprite()
    {
        index++; // 精灵数组的角标加1
        if (index >= sprites.Length) // 如果已经到达精灵数组的末尾
        {
            index = 0; // 将角标重置为0
            tutorialUI.SetActive(false);
        }

        //image.sprite = sprites[index]; // 设置图像的源图像为精灵数组中对应角标的精灵
    }
}