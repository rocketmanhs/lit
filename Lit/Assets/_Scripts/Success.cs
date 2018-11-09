﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Success : MonoBehaviour {
    
    public Text winText; 
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        winText.text = "You Win!";
        Time.timeScale = 0;
    }
}