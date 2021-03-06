﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class PixelizationEffect : MonoBehaviour
{
    public Material pixelMaterial;
    public void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, destination, pixelMaterial);
    }
}
