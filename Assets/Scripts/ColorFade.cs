using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ColorFade : MonoBehaviour
{
	private IEnumerator Start()
	{
		var image = GetComponent<Image>();

		while (true)
		{
			image.DOFade(0f, .5f);
			yield return new WaitForSeconds(.5f);
			image.DOFade(1f, .5f);
			yield return new WaitForSeconds(1f);
		}
	}
}