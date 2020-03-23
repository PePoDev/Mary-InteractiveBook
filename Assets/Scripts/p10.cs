using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

public class p10 : MonoBehaviour
{
	public RectTransform tutorial;

	public Image smartPhone;
	public Sprite smartPhoneOff;

	public Image สาย;
	public Sprite ถอดสาย;

	public Image notebook;
	public Image notebookClose;
	
	private bool m_shakeState;

	private IEnumerator Start()
	{
		// Show tutorial
		tutorial.DOAnchorPosX(0, .7f);
		yield return new WaitForSeconds(2f);
		tutorial.DOAnchorPosX(-1000, .7f);
		yield return new WaitForSeconds(1f);
		Destroy(tutorial.gameObject);

		// Shake Smart Phone
		while (m_shakeState)
		{
			smartPhone.GetComponent<RectTransform>().DOAnchorPosX(20, 1f);
			yield return new WaitForSeconds(1f);
			smartPhone.GetComponent<RectTransform>().DOAnchorPosX(-20, 1f);
			yield return new WaitForSeconds(1f);
		}
	}

	public void Decline()
	{
		m_shakeState = false;
	}

	private void Update()
	{
		var x = GetComponent<Image>();
	}
}