/***
 * 
 * 音乐管理器
 * 
 * **/
using LitJson;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheirCar : WhigSuccessor<TheirCar>
{
    //音频组件管理队列的对象
    private GlassHolderFlora GlassFlora;
    // 用于播放背景音乐的音乐源
    private AudioSource m_bgTheir= null;
    //播放音效的音频组件管理列表
    private List<AudioSource> ExamGlassHolderRent;
    //检查已经播放的音频组件列表中没有播放的组件的更新频率
    private float ShineChemurgy= 2f;
    //背景音乐开关
    private bool _BgTheirIntent;
    //音效开关
    private bool _SingerTheirIntent;
    //音乐音量
    private float _GoPowder= 1f;
    //音效音量
    private float _SingerPowder= 1f;
    string BGM_Step= "";

    public Dictionary<string, GlassFlier> GlassHygieneMelt;
    public Dictionary<string, AudioClip> GlassAkinMelt;

    public List<string> IonizeStepCheck;
    // 控制背景音乐音量大小
    public float GoPowder    {
        get
        {
            return BgTheirIntent ? LeoPowder(BGM_Step) : 0f;
        }
        set
        {
            _GoPowder = value;
            //背景音乐开的状态下，声音随控制调节
        }
    }

    //控制音效音量的大小
    public float SingerPotion    {
        get { return _SingerPowder; }
        set
        {
            _SingerPowder = value;
            YouSeaSingerPowder();
        }
    }
    //控制背景音乐开关
    public bool BgTheirIntent    {
        get
        {

            _BgTheirIntent = AutoTineScratch.BuyGirl("_BgMusicSwitch");
            return _BgTheirIntent;
        }
        set
        {
            if (m_bgTheir)
            {
                _BgTheirIntent = value;
                AutoTineScratch.YouGirl("_BgMusicSwitch", _BgTheirIntent);
                m_bgTheir.volume = GoPowder;
            }
        }
    }
    public void FenTwoShaftRawUser()
    {
        m_bgTheir.volume = 0;
    }
    public void FenTwoGoslingRawUser()
    {
        m_bgTheir.volume = GoPowder;
    }
    //控制音效开关
    public bool SingerTheirIntent    {
        get
        {
            _SingerTheirIntent = AutoTineScratch.BuyGirl("_EffectMusicSwitch");
            return _SingerTheirIntent;
        }
        set
        {
            _SingerTheirIntent = value;
            AutoTineScratch.YouGirl("_EffectMusicSwitch", _SingerTheirIntent);

        }
    }
    public TheirCar()
    {
        ExamGlassHolderRent = new List<AudioSource>();
    }
    protected override void Awake()
    {
        IonizeStepCheck = new List<string>();
        if (!PlayerPrefs.HasKey("first_music_setBool") || !AutoTineScratch.BuyGirl("first_music_set"))
        {
            AutoTineScratch.YouGirl("first_music_set", true);
            AutoTineScratch.YouGirl("_BgMusicSwitch", true);
            AutoTineScratch.YouGirl("_EffectMusicSwitch", true);
        }
        GlassFlora = new GlassHolderFlora(this);

        TextAsset json = Resources.Load<TextAsset>("Audio/AudioInfo");
        GlassHygieneMelt = JsonMapper.ToObject<Dictionary<string, GlassFlier>>(json.text);
    }
    private void Start()
    {
        StartCoroutine(nameof(ShineIfDewGlassSculpture));
    }
    public void NoseTheirCar()
    {
        GlassAkinMelt = new Dictionary<string, AudioClip>();
        foreach (string key in GlassHygieneMelt.Keys)
        {
            GlassAkinMelt.Add(key, Resources.Load<AudioClip>(GlassHygieneMelt[key].filePath));
        }

    }
    /// <summary>
    /// 定时检查没有使用的音频组件并回收
    /// </summary>
    /// <returns></returns>
    IEnumerator ShineIfDewGlassSculpture()
    {
        while (true)
        {
            //定时更新
            yield return new WaitForSeconds(ShineChemurgy);
            for (int i = 0; i < ExamGlassHolderRent.Count; i++)
            {
                //防止数据越界
                if (i < ExamGlassHolderRent.Count)
                {
                    //确保物体存在
                    if (ExamGlassHolderRent[i])
                    {
                        //音频为空或者没有播放为返回队列条件
                        if ((ExamGlassHolderRent[i].clip == null || !ExamGlassHolderRent[i].isPlaying))
                        {
                            //返回队列
                            GlassFlora.UnDewGlassSculpture(ExamGlassHolderRent[i]);
                            //从播放列表中删除
                            ExamGlassHolderRent.Remove(ExamGlassHolderRent[i]);
                        }
                    }
                    else
                    {
                        //移除在队列中被销毁但是是在list中存在的垃圾数据
                        ExamGlassHolderRent.Remove(ExamGlassHolderRent[i]);
                    }
                }

            }
        }
    }
    /// <summary>
    /// 设置当前播放的所有音效的音量
    /// </summary>
    private void YouSeaSingerPowder()
    {
        for (int i = 0; i < ExamGlassHolderRent.Count; i++)
        {
            if (ExamGlassHolderRent[i] && ExamGlassHolderRent[i].isPlaying)
            {
                ExamGlassHolderRent[i].volume = _SingerTheirIntent ? _SingerPowder : 0f;
            }
        }
    }
    /// <summary>
    /// 播放背景音乐，传进一个音频剪辑的name
    /// </summary>
    /// <param name="bgName"></param>
    /// <param name="restart"></param>
    private void ExamGoFork(object bgName, bool restart = false)
    {

        BGM_Step = bgName.ToString();
        if (m_bgTheir == null)
        {
            //拿到一个音频组件  背景音乐组件在某一时间段唯一存在
            m_bgTheir = GlassFlora.BuyGlassSculpture();
            //开启循环
            m_bgTheir.loop = true;
            //开始播放
            m_bgTheir.playOnAwake = false;
            //加入播放列表
            //PlayAudioSourceList.Add(m_bgMusic);
        }

        if (!BgTheirIntent)
        {
            m_bgTheir.volume = 0;
        }

        //定义一个空的字符串
        string curBgName = string.Empty;
        //如果这个音乐源的音频剪辑不为空的话
        if (m_bgTheir.clip != null)
        {
            //得到这个音频剪辑的name
            curBgName = m_bgTheir.clip.name;
        }

        // 根据用户的音频片段名称, 找到AuioClip, 然后播放,
        //ResourcesMgr是提前定义好的查找音频剪辑对应路径的单例脚本，并动态加载出来
        //AudioClip clip = Resources.Load<AudioClip>(AudioSettingDict[BGM_Name].filePath);
        AudioClip clip = GlassAkinMelt[BGM_Step];

        //如果找到了，不为空
        if (clip != null)
        {
            //如果这个音频剪辑已经复制给类音频源，切正在播放，那么直接跳出
            if (clip.name == curBgName && !restart)
            {
                return;
            }
            //否则，把改音频剪辑赋值给音频源，然后播放
            m_bgTheir.clip = clip;
            m_bgTheir.volume = GoPowder;
            m_bgTheir.Play();
        }
        else
        {
            //没找到直接报错
            // 异常, 调用写日志的工具类.
            //UnityEngine.Debug.Log("没有找到音频片段");
            if (m_bgTheir.isPlaying)
            {
                m_bgTheir.Stop();
            }
            m_bgTheir.clip = null;
        }
    }
    /// <summary>
    /// 播放音效
    /// </summary>
    /// <param name="effectName"></param>
    /// <param name="defAudio"></param>
    /// <param name="volume"></param>
    private void ExamSingerFork(object effectName, bool defAudio = true, float volume = 1f)
    {
        if (!SingerTheirIntent)
        {
            return;
        }
        //获取音频组件
        AudioSource m_effectMusic = GlassFlora.BuyGlassSculpture();
        if (m_effectMusic.isPlaying)
        {
            Debug.Log("-------------------------------当前音效正在播放,直接返回");
            return;
        };
        m_effectMusic.loop = false;
        m_effectMusic.playOnAwake = false;
        m_effectMusic.volume = LeoPowder(effectName.ToString());
        //Debug.Log(m_effectMusic.volume);
        //根据查找路径加载对应的音频剪辑
        Debug.Log(GlassHygieneMelt[effectName.ToString()].filePath);
        //AudioClip clip = Resources.Load<AudioClip>(AudioSettingDict[effectName.ToString()].filePath);
        AudioClip clip = GlassAkinMelt[effectName.ToString()];
        //如果为空的话，直接报错，然后跳出
        if (clip == null)
        {
            UnityEngine.Debug.Log("没有找到音效片段");
            //没加入播放列表直接返回给队列
            GlassFlora.UnDewGlassSculpture(m_effectMusic);
            return;
        }
        m_effectMusic.clip = clip;
        //加入播放列表
        ExamGlassHolderRent.Add(m_effectMusic);
        //否则，就是clip不为空的话，如果defAudio=true，直接播放
        if (defAudio)
        {
            Debug.Log("音效播放");
            m_effectMusic.PlayOneShot(clip, volume);
        }
        else
        {
            //指定点播放
            AudioSource.PlayClipAtPoint(clip, Camera.main.transform.position, volume);
        }
    }
    private void ExamSingerFork(object effectName, float start, float end)
    {
        bool defAudio = true;
        float volume = 1f;
        if (!SingerTheirIntent)
        {
            return;
        }
        //获取音频组件
        AudioSource m_effectMusic = GlassFlora.BuyGlassSculpture();
        if (m_effectMusic.isPlaying)
        {
            Debug.Log("-------------------------------当前音效正在播放,直接返回");
            return;
        };
        m_effectMusic.loop = false;
        m_effectMusic.playOnAwake = false;
        m_effectMusic.volume = LeoPowder(effectName.ToString());
        //Debug.Log(m_effectMusic.volume);
        //根据查找路径加载对应的音频剪辑
        //AudioClip clip = Resources.Load<AudioClip>(AudioSettingDict[effectName.ToString()].filePath);
        AudioClip clip = GlassAkinMelt[effectName.ToString()];
        //如果为空的话，直接报错，然后跳出
        if (clip == null)
        {
            UnityEngine.Debug.Log("没有找到音效片段");
            //没加入播放列表直接返回给队列
            GlassFlora.UnDewGlassSculpture(m_effectMusic);
            return;
        }
        m_effectMusic.clip = clip;
        //加入播放列表
        ExamGlassHolderRent.Add(m_effectMusic);
        //否则，就是clip不为空的话，如果defAudio=true，直接播放
        if (defAudio)
        {
            Debug.Log("音效播放");
            m_effectMusic.Stop();
            m_effectMusic.SetScheduledStartTime(start);
            m_effectMusic.SetScheduledEndTime(end);
            m_effectMusic.PlayOneShot(clip, volume);
        }
        else
        {
            //指定点播放
            AudioSource.PlayClipAtPoint(clip, Camera.main.transform.position, volume);
        }
    }
    //播放各种音频剪辑的调用方法，MusicType是提前写好的存放各种音乐名称的枚举类，便于外面直接调用
    public void ExamGo(TheirRear.UIMusic bgName, bool restart = false)
    {
        ExamGoFork(bgName, restart);
    }

    public void ExamGo(TheirRear.SceneMusic bgName, bool restart = false)
    {
        ExamGoFork(bgName, restart);
    }

    public void ExamSinger(TheirRear.UIMusic bgName, float limit, System.Action finish = null)
    {
        ExamSingerFork(bgName, limit, finish);
    }

    public void ExamSinger(TheirRear.SceneMusic bgName, float limit, System.Action finish = null)
    {
        ExamSingerFork(bgName, limit, finish);
    }


    private void ExamSingerFork(object effectName, float limit, System.Action finish = null)
    {
        if (!IonizeStepCheck.Contains(effectName.ToString()))
        {
            if (finish != null)
            {
                finish();
            }
            ExamSingerFork(effectName, true, 1);
            IonizeStepCheck.Add(effectName.ToString());
            StartCoroutine(EngineSingerStep(effectName.ToString(), limit));
        }
    }
    IEnumerator EngineSingerStep(string name, float limit)
    {
        yield return new WaitForSeconds(limit);
        if (IonizeStepCheck.Contains(name))
        {
            IonizeStepCheck.Remove(name);
        }
    }
    public void ExamSinger(TheirRear.UIMusic effectName, float start, float end)
    {
        ExamSingerFork(effectName, start, end);
    }
    //播放各种音频剪辑的调用方法，MusicType是提前写好的存放各种音乐名称的枚举类，便于外面直接调用
    public void ExamSinger(TheirRear.UIMusic effectName, bool defAudio = true, float volume = 1f)
    {
        ExamSingerFork(effectName, defAudio, volume);
    }

    public void ExamSinger(TheirRear.SceneMusic effectName, bool defAudio = true, float volume = 1f)
    {
        ExamSingerFork(effectName, defAudio, volume);
    }
    float LeoPowder(string name)
    {
        if (GlassHygieneMelt == null)
        {
            TextAsset json = Resources.Load<TextAsset>("Audio/AudioInfo");
            GlassHygieneMelt = JsonMapper.ToObject<Dictionary<string, GlassFlier>>(json.text);
        }

        if (GlassHygieneMelt.ContainsKey(name))
        {
            return (float)GlassHygieneMelt[name].volume;

        }
        else
        {
            return 1;
        }
    }

}