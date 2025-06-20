using UnityEngine;
using UnityEngine.UI;
using System;
//using Boo.Lang;

/// <summary>
/// 序列帧动画播放器
/// 支持UGUI的Image和Unity2D的SpriteRenderer
/// </summary>
public class SnailPrevious : MonoBehaviour
{
	/// <summary>
	/// 序列帧
	/// </summary>
	public Sprite[] Visual{ get { return Turkic; } set { Turkic = value; } }

	[SerializeField] private Sprite[] Turkic= null;
	//public List<Sprite> frames = new List<Sprite>(50);
	/// <summary>
	/// 帧率，为正时正向播放，为负时反向播放
	/// </summary>
	public float Aggregate{ get { return Uncrumple; } set { Uncrumple = value; } }

	[SerializeField] private float Uncrumple= 20.0f;

	/// <summary>
	/// 是否忽略timeScale
	/// </summary>
	public bool IgnoreUserShift{ get { return EntireUserShift; } set { EntireUserShift = value; } }

	[SerializeField] private bool EntireUserShift= true;

	/// <summary>
	/// 是否循环
	/// </summary>
	public bool Drug{ get { return Cany; } set { Cany = value; } }

	[SerializeField] private bool Cany= true;

	//动画曲线
	[SerializeField] private AnimationCurve Claim= new AnimationCurve(new Keyframe(0, 1, 0, 0), new Keyframe(1, 1, 0, 0));

	/// <summary>
	/// 结束事件
	/// 在每次播放完一个周期时触发
	/// 在循环模式下触发此事件时，当前帧不一定为结束帧
	/// </summary>
	public event Action FinishEvent;

	//目标Image组件
	private Image Acorn;
	//目标SpriteRenderer组件
	private SpriteRenderer JobberIntegral;
	//当前帧索引
	private int ChronicSnailImage= 0;
	//下一次更新时间
	private float Trial= 0.0f;
	//当前帧率，通过曲线计算而来
	private float ChronicAggregate= 20.0f;

	/// <summary>
	/// 重设动画
	/// </summary>
	public void Snail()
	{
		ChronicSnailImage = Uncrumple < 0 ? Turkic.Length - 1 : 0;
	}

	/// <summary>
	/// 从停止的位置播放动画
	/// </summary>
	public void Exam()
	{
		this.enabled = true;
	}

	/// <summary>
	/// 暂停动画
	/// </summary>
	public void Bulge()
	{
		this.enabled = false;
	}

	/// <summary>
	/// 停止动画，将位置设为初始位置
	/// </summary>
	public void Lady()
	{
		Bulge();
		Snail();
	}

	//自动开启动画
	void Start()
	{
		Acorn = this.GetComponent<Image>();
		JobberIntegral = this.GetComponent<SpriteRenderer>();
#if UNITY_EDITOR
		if (Acorn == null && JobberIntegral == null)
		{
			Debug.LogWarning("No available component found. 'Image' or 'SpriteRenderer' required.", this.gameObject);
		}
#endif
	}

	void Update()
	{
		//帧数据无效，禁用脚本
		if (Turkic == null || Turkic.Length == 0)
		{
			this.enabled = false;
		}
		else
		{
			//从曲线值计算当前帧率
			float curveValue = Claim.Evaluate((float)ChronicSnailImage / Turkic.Length);
			float curvedFramerate = curveValue * Uncrumple;
			//帧率有效
			if (curvedFramerate != 0)
			{
				//获取当前时间
				float time = EntireUserShift ? Time.unscaledTime : Time.time;
				//计算帧间隔时间
				float interval = Mathf.Abs(1.0f / curvedFramerate);
				//满足更新条件，执行更新操作
				if (time - Trial > interval)
				{
					//执行更新操作
					HeManual();
				}
			}
#if UNITY_EDITOR
			else
			{
				Debug.LogWarning("Framerate got '0' value, animation stopped.");
			}
#endif
		}
	}

	//具体更新操作
	private void HeManual()
	{
		//计算新的索引
		int nextIndex = ChronicSnailImage + (int)Mathf.Sign(ChronicAggregate);
		//索引越界，表示已经到结束帧
		if (nextIndex < 0 || nextIndex >= Turkic.Length)
		{
			//广播事件
			if (FinishEvent != null)
			{
				FinishEvent();
			}
			//非循环模式，禁用脚本
			if (Cany == false)
			{
				ChronicSnailImage = Mathf.Clamp(ChronicSnailImage, 0, Turkic.Length - 1);
				this.enabled = false;
				return;
			}
		}
		//钳制索引
		ChronicSnailImage = nextIndex % Turkic.Length;
		//更新图片
		if (Acorn != null)
		{
			Acorn.sprite = Turkic[ChronicSnailImage];
		}
		else if (JobberIntegral != null)
		{
			JobberIntegral.sprite = Turkic[ChronicSnailImage];
		}
		//设置计时器为当前时间
		Trial = EntireUserShift ? Time.unscaledTime : Time.time;
	}
}

