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

    public string Title { get; set; }           //����
    public string Composer { get; set; }        //�۰
    public int Tempo { get; set; }              //���� BPM
    //public string KeySignature { get; set; }  //����
    //public string TimeSignature { get; set; } //����
    //public List<Note> Notes { get; set; }     //��Ʈ
    //public List<Pedal> Pedals { get; set; }   //���
    
    //��Ʈ
    //public string NoteID { get; set; }  // ���� ID
    //public string Pitch { get; set; }   // �� ���� (��: "C4", "G#5")
    //public int MIDIPitch { get; set; }  // MIDI ��ǥ ��ȣ
    //public string Duration { get; set; }  // ���� (��: "1/4", "1/8")
    //public int Velocity { get; set; }   // �� ���� (0~127)
    //public double StartTime { get; set; } // ���� ���� (��Ʈ ����)
    //public int Staff { get; set; }  // 1: ������, 2: �޼�
    //public string Hand { get; set; }  // "right" or "left"
    //public bool Tie { get; set; }     // ������ ����
    //public bool Slur { get; set; }    // ���� ����
    //public bool Staccato { get; set; } // ��Ÿī�� ����
    //public string Dynamic { get; set; } // �����ȣ (��: "p", "mf")

    //���
    //public string PedalType { get; set; } // "sustain", "soft", "sostenuto"
    //public double PedalStart { get; set; } // ��� ���� ��Ʈ
    //public double PedalEnd { get; set; } // ��� ���� ��Ʈ
}
