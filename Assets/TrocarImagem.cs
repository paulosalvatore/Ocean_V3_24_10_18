using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrocarImagem : MonoBehaviour
{
	public Material material1;
	public Material material2;

	private void Start()
	{
		InvokeRepeating("AlterarSkybox", 20f, 20f);
	}

	private void AlterarSkybox()
	{
		RenderSettings.skybox = RenderSettings.skybox == material1 ? material2 : material1;
	}
}
