using UnityEngine;

public class Sheet_Music : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public string Title { get; set; }           //제목
    public string Composer { get; set; }        //작곡가
    public int Tempo { get; set; }              //템포 BPM
    //public string KeySignature { get; set; }  //조성
    //public string TimeSignature { get; set; } //박자
    //public List<Note> Notes { get; set; }     //노트
    //public List<Pedal> Pedals { get; set; }   //페달
    
    //노트
    //public string NoteID { get; set; }  // 고유 ID
    //public string Pitch { get; set; }   // 음 높이 (예: "C4", "G#5")
    //public int MIDIPitch { get; set; }  // MIDI 음표 번호
    //public string Duration { get; set; }  // 길이 (예: "1/4", "1/8")
    //public int Velocity { get; set; }   // 음 강도 (0~127)
    //public double StartTime { get; set; } // 시작 시점 (비트 단위)
    //public int Staff { get; set; }  // 1: 오른손, 2: 왼손
    //public string Hand { get; set; }  // "right" or "left"
    //public bool Tie { get; set; }     // 이음줄 여부
    //public bool Slur { get; set; }    // 슬러 여부
    //public bool Staccato { get; set; } // 스타카토 여부
    //public string Dynamic { get; set; } // 강약기호 (예: "p", "mf")

    //페달
    //public string PedalType { get; set; } // "sustain", "soft", "sostenuto"
    //public double PedalStart { get; set; } // 페달 시작 비트
    //public double PedalEnd { get; set; } // 페달 종료 비트
}
