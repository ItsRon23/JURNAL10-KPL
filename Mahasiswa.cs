using System;

public class Mahasiswa
{

    // deklarasi attribut nama, NIM
    public String nama { get; set; }
    public String NIM { get; set; }
    public String course { get; set; }
    public String year { get; set; }   
    // constructor class Mahasiswa
    public Mahasiswa(String nama, String NIM, string course, string year)
    {
        this.nama = nama;
        this.NIM = NIM;
        this.course = course;
        this.year = year;
    }

}