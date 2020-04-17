using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class p17 : MonoBehaviour
{
	public RectTransform smartphone;

	public GameObject videoPhoneAccept;

	public GameObject hideGroup;
	
	public bool phoneShake = true;

	private IEnumerator Start()
	{
		while (phoneShake)
		{
			smartphone.DOAnchorPosX(30, .6f);
			yield return new WaitForSeconds(.6f);
			smartphone.DOAnchorPosX(-30, .6f);
			yield return new WaitForSeconds(.6f);
		}
	}

	public void phoneAccept()
	{
		GetComponent<Image>().enabled = false;
		hideGroup.SetActive(false);
		phoneShake = false;
		videoPhoneAccept.SetActive(true);
		DOTween.Clear();
	}

	public void StopShake()
	{
		phoneShake = false;
		DOTween.Clear();
	}
}