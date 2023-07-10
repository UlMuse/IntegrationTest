using System;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GameBuilder
{
    static void MakeAndroidBuild()
    {
        string[] defaultScene = { 
            "Assets/Scenes/SampleScene.unity",
            };

        BuildPipeline.BuildPlayer(defaultScene, "MyGame.apk" ,
            BuildTarget.Android, BuildOptions.None);
    }

}