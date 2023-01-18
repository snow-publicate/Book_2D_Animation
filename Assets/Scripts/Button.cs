using UnityEngine;
using UnityEngine.Playables; //PlayableDirector를 다루기 위한 네임스페이스 선언
using UnityEngine.Timeline; //Timeline을 다루기 위한 네임스페이스 선언
 
public class Button : MonoBehaviour 
{
 
    public PlayableDirector playableDirector; //타임라인제어하는 객체(Main Camera)를 담는 변수
    public TimelineAsset timeline_Correct; //Quiz-Correct 타임라인 담는 변수 선언
    public TimelineAsset timeline_Wrong; //Quiz-No 타임라인 담는 변수 선언
    public GameObject Q; //Q객체를 담는 변수 선언
    public GameObject YesButton; //Button-Yes객체를 담는 변수 선언
    public GameObject NoButton; //Button-No객체를 담는 변수 선언
 
    public void Correct()
    {
        //Q, Butten-Yes, Button-No 객체 비활성화
        Q.gameObject.SetActive(false);
        YesButton.gameObject.SetActive(false);
        NoButton.gameObject.SetActive(false);

        // timeline_Correct 타임라인을 시작
        playableDirector.Play(timeline_Correct);
    }
 
    public void Wrong()
    {
        //Q, Butten-Yes, Button-No 객체 비활성화
        Q.gameObject.SetActive(false);
        YesButton.gameObject.SetActive(false);
        NoButton.gameObject.SetActive(false);   
             
		// timeline_Wrong 타임라인을 시작
        playableDirector.Play(timeline_Wrong);
    }
}

