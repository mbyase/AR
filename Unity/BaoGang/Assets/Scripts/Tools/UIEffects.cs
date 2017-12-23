﻿using System;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIEffects : MonoBehaviour
{
	Image fillImg;
	Sequence mySque;

	#region 填充饼图操作

	public void StartFillImage(Ryan3DButton btn)
	{
		if (!fillImg)
		{
			fillImg = GetComponent<Image>();
			fillImg.fillAmount = 1f;
			fillImg.transform.localScale = Vector3.one * .2f;
			mySque = DOTween.Sequence();
			mySque.Append(fillImg.transform.DOScale(Vector3.one * 0.5f, .2f).SetEase(Ease.OutSine).OnComplete(() => { Debug.Log("HLdddLLO"); }));
			//弹出界面
			mySque.Append(fillImg.DOFillAmount(0, 3f));
			mySque.OnComplete(() => { btn.MouseSelect(); });
		}
	}

	//public void StartFillImage(Action<InspectionItem> callback, InspectionItem item)
	//{
	//	if (!fillImg)
	//	{
	//		fillImg = GetComponent<Image>();
	//		fillImg.fillAmount = 1f;
	//		fillImg.transform.localScale = Vector3.one * .2f;
	//		mySque = DOTween.Sequence();
	//		mySque.Append(fillImg.transform.DOScale(Vector3.one * 0.5f, .2f).SetEase(Ease.OutSine).OnComplete(() => { Debug.Log("HLdddLLO"); }));
	//		//弹出界面
	//		mySque.Append(fillImg.DOFillAmount(0, 3f));
	//		mySque.OnComplete(() => { callback.Invoke(item); });
	//	}
	//}

	public void StopFillImage()
	{
		if (fillImg)
		{
			mySque.Kill();
			fillImg.fillAmount = 1;
			fillImg = null;
		}
	}

	#endregion
}
