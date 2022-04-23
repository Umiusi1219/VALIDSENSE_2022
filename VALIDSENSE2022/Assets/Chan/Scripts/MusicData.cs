using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicData
{
    public static long Timer;
    public static long BPM;
    Func<long> getTimer = () => {return (long)Math.Round((double)Timer/1000);};
}
