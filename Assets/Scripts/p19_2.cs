using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class p19_2 : MonoBehaviour
{
	public RectTransform box;
	public GameObject boxVideo;
	public RectTransform air;
	public RectTransform airStatus;
	public GameObject newVideo;

	private bool m_isAir = false;

	private void Start()
	{
		box.DOAnchorPosX(0, 1.5f);
	}

	public void UseAir()
	{
		air.DOAnchorPosY(0, 2f);
		StartCoroutine(func());

		IEnumerator func()
		{
			yield return new WaitForSeconds(2.7f);
			air.DOAnchorPosY(-1969f, 3f);
			yield return new WaitForSeconds(1.5f);
			airStatus.DOAnchorPosY(0, 3f);
			yield return new WaitForSeconds(5f);
			airStatus.DOAnchorPosY(1945f, 3f);
			yield return new WaitForSeconds(2.5f);
			air.gameObject.SetActive(false);
			airStatus.gameObject.SetActive(false);
			box.gameObject.SetActive(true);
			m_isAir = true;
		}
	}

	public GameObject itimVideo;
	public GameObject itim;
	private bool m_itim = false;

	public void UseItim()
	{
		if (m_isAir == false)
		{
			return;
		}

		newVideo.SetActive(false);
		itimVideo.SetActive(true);
		box.gameObject.SetActive(true);
		boxVideo.SetActive(false);
		itim.SetActive(false);
		m_itim = true;
	}

	public GameObject kattleVideo;
	public GameObject kattle;
	public RectTransform quoteKattle;
	private bool m_kattle = false;

	public void UseKattle()
	{
		if (m_itim == false)
		{
			return;
		}

		itimVideo.SetActive(false);
		kattleVideo.SetActive(true);
		boxVideo.SetActive(false);
		kattle.SetActive(false);
		m_itim = true;
		quoteKattle.DOAnchorPosY(0, 2f);
		StartCoroutine(func());
		m_kattle = true;

		IEnumerator func()
		{
			yield return new WaitForSeconds(4f);
			quoteKattle.DOAnchorPosY(1706f, 2f);
			yield return new WaitForSeconds(2f);
			box.gameObject.SetActive(true);
		}
	}

	public GameObject lastVideo;
	public GameObject last;
	public RectTransform nextButton;

	public void Use4()
	{
		if (m_kattle == false)
		{
			return;
		}

		kattleVideo.SetActive(false);
		lastVideo.SetActive(true);
		boxVideo.SetActive(false);
		last.SetActive(false);
		box.gameObject.SetActive(false);
	}
}