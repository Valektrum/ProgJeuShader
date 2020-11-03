using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class CameraEffect : MonoBehaviour
{
	// Start is called before the first frame update
	private Material material;

	private void Start()
	{
	}

	// Update is called once per frame
	private void Update()
	{
	}

	private void Awake()
	{
		material = new Material(Shader.Find("Hidden/NewImageEffectShader"));
	}

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		RenderTexture buffer = RenderTexture.GetTemporary(source.width, source.height, 24);
		Graphics.Blit(source, buffer, material);
		Graphics.Blit(buffer, destination);
		RenderTexture.ReleaseTemporary(buffer);
	}
}