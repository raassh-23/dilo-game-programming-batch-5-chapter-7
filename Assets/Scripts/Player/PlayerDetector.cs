﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Comparers;

public class PlayerDetector : MonoBehaviour
{
    public GameOverManager gameOverManager;

    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Enemy" && !other.isTrigger) {
            float enemyDistance = Vector3.Distance(transform.position, other.transform.position);

            gameOverManager.ShowWarning(enemyDistance);
        }
    }
}
