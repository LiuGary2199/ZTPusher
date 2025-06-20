/***
 * 
 * AudioSource组件管理(音效，背景音乐除外)
 * 
 * **/
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GlassHolderFlora 
{
    //音乐的管理者
    private GameObject GlassMgr;
    //音乐组件管理队列
    private List<AudioSource> GlassSculptureFlora;
    //音乐组件默认容器最大值  
    private int ShePaint= 25;
    public GlassHolderFlora(TheirCar audioMgr)
    {
        GlassMgr = audioMgr.gameObject;
        NoseGlassHolderFlora();
    }
  
    /// <summary>
    /// 初始化队列
    /// </summary>
    private void NoseGlassHolderFlora()
    {
        GlassSculptureFlora = new List<AudioSource>();
        for(int i = 0; i < ShePaint; i++)
        {
            NorGlassHolderSitBodyCar();
        }
    }
    /// <summary>
    /// 给音乐的管理者添加音频组件，同时组件加入队列
    /// </summary>
    private AudioSource NorGlassHolderSitBodyCar()
    {
        AudioSource audio = GlassMgr.AddComponent<AudioSource>();
        GlassSculptureFlora.Add(audio);
        return audio;
    }
    /// <summary>
    /// 获取一个音频组件
    /// </summary>
    /// <param name="audioMgr"></param>
    /// <returns></returns>
    public AudioSource BuyGlassSculpture()
    {
        if (GlassSculptureFlora.Count > 0)
        {
            AudioSource audio = GlassSculptureFlora.Find(t => !t.isPlaying);
            if (audio)
            {
                GlassSculptureFlora.Remove(audio);
                return audio;
            }
            //队列中没有了，需额外添加
            return NorGlassHolderSitBodyCar();
            //直接返回队列中存在的组件
            //return AudioComponentQueue.Dequeue();
        }
        else
        {
            //队列中没有了，需额外添加
            return  NorGlassHolderSitBodyCar();
        }
    }
    /// <summary>
    /// 没有被使用的音频组件返回给队列
    /// </summary>
    /// <param name="audio"></param>
    public void UnDewGlassSculpture(AudioSource audio)
    {
        if (GlassSculptureFlora.Contains(audio)) return;
        if (GlassSculptureFlora.Count >= ShePaint)
        {
            GameObject.Destroy(audio);
            //Debug.Log("删除组件");
        }
        else
        {
            audio.clip = null;
            GlassSculptureFlora.Add(audio);
        }

        //Debug.Log("队列长度是" + AudioComponentQueue.Count);
    }
    
}
