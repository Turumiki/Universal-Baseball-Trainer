using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    bool buttonflag = true;//ボタンの状態を記録する変数
    public Slider DtimeSlider;//スライダー用の変数
    public Text buttontext;//打球＆リトライボタンのテキスト用変数
    public Text delaytext;//ディレイ時間表示のテキスト用変数
    public float Delaytime;//ディレイ時間の変数

    void Start()
    {
        Instantiate(Resources.Load("Prefab/dakyu"));//スクリプト開始時にResourcesフォルダの中のPrefabフォルダから"dakyu"プレファブを読み込み、配置。
        buttontext.text = "バットをふる！"; //ボタンのテキストを変更
        buttonflag = true;//buttonflagをtrueに変更
    }

    void Update()
    {
        Delaytime = DtimeSlider.value;//Delaytime変数にスライダーの値を読み込む
        delaytext.text = "ラグ:" + Delaytime + "秒";//読み込んだスライダーの値に、文字を追加  
    }

    public void OnClick()//ボタンがクリックされた時の関数
    {
        if (buttonflag == true)//buttonflagがtrueなら
        {
            //バットを振り、ボタンの表示を変える
            Invoke("Dakyu", Delaytime);//Dakyu関数をDelaytimeで設定された秒数後に実行する。
            Retry();
        }
        else//buttonflagがfalseなら
        {
            GameObject dakyu = GameObject.Find("dakyu(Clone)");//シーン上から"dakyu(Clone)"という名前のオブジェクトを探索し、GameObject"dakyu"に渡す。
            Destroy(dakyu); //回転台、バット、ボールを削除
            Start();
        }
    }

    private void Retry()
    {
        buttontext.text = "もういっかい"; //ボタンのテキストを「もういっかい」に変更
        buttonflag = false; //フラグをfalseに変更
    }
    public void Dakyu()    //バットを振る変数
    {
        GameObject obj = GameObject.Find("BatStopper"); //"BatStpper"という名前のオブジェクトを探し、「obj」に代入
        Destroy(obj); //ストッパーを削除
    }
}
