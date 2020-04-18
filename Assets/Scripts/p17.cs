using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class p17 : MonoBehaviour
{
	public RectTransform smartphone;
	public RectTransform tele;

	public GameObject videoPhoneAccept;
	public GameObject videoTeleAccept;

	public GameObject hideGroup;

	public bool phoneShake = true;

	private IEnumerator Start()
	{
		while (phoneShake)
		{
			smartphone.DOAnchorPosX(30, .6f);
			yield return new WaitForSeconds(.6f);
			smartphone.DOAnchorPosX(-30f, .6f);
			yield return new WaitForSeconds(.6f);
		}

		yield return new WaitUntil(() => isTele);
		
		while (isTele)
		{
			tele.DOAnchorPosX(596, .6f);
			yield return new WaitForSeconds(.6f);
			tele.DOAnchorPosX(460.6f, .6f);
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

	public void teleAccept()
	{
		GetComponent<Image>().enabled = false;
		hideGroup.SetActive(false);
		videoTeleAccept.SetActive(true);
	}

	public bool isTele = false;

	public void StartShackTele()
	{
		isTele = true;
	}

	public void StopShackTele()
	{
		isTele = false;
		DOTween.Clear();
	}
}