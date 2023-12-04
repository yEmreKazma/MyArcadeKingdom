using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICollectible
{
    string name { get; }
    int amount { get; set; }
    float collectTime { get; }
    float respawnTime { get; }
    bool isDepleted { get; }
    void Collect();

}
