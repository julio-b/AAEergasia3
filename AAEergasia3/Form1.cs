using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace AAEergasia3 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            MusicLib m = new MusicLib();
            //m.InsertNewFile("aa.mp3", "AA", "aaaa", 1111, "A#", "dottt", 111111);
            //m.InsertNewFile("bbb.bbb", "BBBB", "werbb", 22, "CCC", "c", 2);
            ///m.InsertNewFile("musicwow22.mp3", "asqwqw N Or", "qwe", 2006, "Thrash Metal", "english", 230);
            //m.InsertNewFile("i333weqwe.mp3", "meee", "QWEr", 2006, "Thrash Metal", "english", 0);
            m.InsertNewFile("memem-uouou.mp3", "ououou", "memem", 2016, "Thrash Metal", "english", 0);
            m.InsertNewFile("Mfofo - LSSDD.mp3", "LSSDD", "Mfofoo", 2046, "Thrash Metal", "english");
            m.InsertNewFile("HVTT.mp3", "Tor", "wqe", 20776, "Thrash Metal");
            m.InsertNewFile("Deletethis.mp3", "Tor", "wqe", 20776, "Thrash Metal");
            m.DeleteFile("Deletethis.mp3");
            m.EditFileInfos("HVTT.mp3", "name", "fucccccc");
            m.EditFileInfos("HVTT.mp3", "year", 2030);
            SQLiteDataReader r = m.GetOrdered();
            for (int i = 0; i < 7; i++) richTextBox1.AppendText(r.GetName(i) + " /");
            richTextBox1.AppendText("\n\n");
            while (r.Read()) {
                //!richTextBox1.AppendText(r["name"]+" "+r["filename"] + "\n");
                for(int i=0; i<7;i++) richTextBox1.AppendText(r.GetValue(i).ToString()+"/");
                richTextBox1.AppendText("\n");
            }


        }
    }
}
