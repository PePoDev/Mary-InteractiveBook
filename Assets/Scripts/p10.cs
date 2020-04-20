using System.Collections;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class p10 : MonoBehaviour
{
	public RectTransform tutorial;

	public Image smartPhone;
	public Sprite smartPhoneOff;

	public Image สาย;
	public Sprite ถอดสาย;

	public Image telephone;

	public Image notebook;
	public Image notebookClose;
	
	private bool m_shakeState = true;
	private bool m_ringState = true;

	public Button decline;
	public Button cut;
	public Button close;
	
	public Image moodlevel;
	public Sprite[] levelSprite;

	public GameObject next;
	
	private IEnumerator Start()
	{
		// Show tutorial
		tutorial.DOAnchorPosX(0, .7f);
		yield return new WaitForSeconds(2f);
		tutorial.DOAnchorPosX(-1000, .7f);
		yield return new WaitForSeconds(1f);
		Destroy(tutorial.gameObject);

		// Shake Smart Phone
		var i = 0;
		while (m_shakeState)
		{
			smartPhone.GetComponent<RectTransform>().DOAnchorPosX(30, .6f);
			yield return new WaitForSeconds(.6f);
			smartPhone.GetComponent<RectTransform>().DOAnchorPosX(-30, .6f);
			yield return new WaitForSeconds(.6f);
			
			i++;
			if (i > 2)
			{
				decline.gameObject.SetActive(true);
			}
			
			if (!m_shakeState)
			{
				decline.gameObject.SetActive(false);
			}
		}
		
		// Rotate Telephone
		i = 0;
		while (m_ringState)
		{
			telephone.GetComponent<RectTransform>().DOAnchorPosX(1272, .6f);
			yield return new WaitForSeconds(.6f);
			telephone.GetComponent<RectTransform>().DOAnchorPosX(1178.6f, .6f);
			yield return new WaitForSeconds(.6f);
			
			i++;
			if (i > 2)
			{
				cut.gameObject.SetActive(true);
			}

			if (!m_ringState)
			{
				cut.gameObject.SetActive(false);
			}
		}
		
		yield return new WaitForSeconds(1f);
		close.gameObject.SetActive(true);
	}

	public void Decline()
	{
		m_shakeState = false;
		smartPhone.overrideSprite = smartPhoneOff;
		decline.gameObject.SetActive(false);
		moodlevel.overrideSprite = levelSprite[1];
	}

	public void Cut()
	{
		m_ringState = false;
		สาย.overrideSprite = ถอดสาย;
		cut.gameObject.SetActive(false);
		moodlevel.overrideSprite = levelSprite[1];
	}
	
	public void Close()
	{
		notebook.gameObject.SetActive(false);
		notebookClose.gameObject.SetActive(true);
		close.gameObject.SetActive(false);
		moodlevel.overrideSprite = levelSprite[2];
		
		next.SetActive(true);
	}
}