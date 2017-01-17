using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;


namespace AAEergasia3 {
    class MusicLib {
        private SQLiteConnection con;
        private string filename = "..\\..\\Externals\\music.sqldb";

        public MusicLib() {
            if (!System.IO.File.Exists(filename)) {
                SQLiteConnection.CreateFile(filename);
            }
            con = new SQLiteConnection("Data Source=" + filename + ";Version=3;");
            con.Open();
            string sql = "CREATE TABLE IF NOT EXISTS music (filename TEXT, name TEXT, author TEXT, year INT, genre TEXT, language TEXT, score INT, UNIQUE(filename))";
            SQLiteCommand command = new SQLiteCommand(sql, con);
            command.ExecuteNonQuery();
        }

        public void InsertNewFile(string filename, string name, string author, int year, string genre, string langueage="english", int score=0) {
            string sql = "INSERT OR IGNORE INTO music (filename, name, author, year, genre, language, score) VALUES ("
                + "'"    + filename
                + "','"  + name
                + "', '" + author
                + "',"   + year
                + ",'"   + genre
                + "','"  + langueage
                + "',"   + score
                + ")";
            SQLiteCommand command = new SQLiteCommand(sql, con);
            command.ExecuteNonQuery();
        }

        public void DeleteFile(string filename) {
            string sql = "DELETE FROM music WHERE filename = '" + filename + "'";
            SQLiteCommand command = new SQLiteCommand(sql, con);
            command.ExecuteNonQuery();
        }

        public void EditFileInfos(string filename, string column, string value) {
            string sql = "UPDATE music SET " + column + "= '" + value + "' WHERE filename = '" + filename + "'";
            SQLiteCommand command = new SQLiteCommand(sql, con);
            command.ExecuteNonQuery();
        }
        public void EditFileInfos(string filename, string column, int value) {
            string sql = "UPDATE music SET " + column + "= " + value + " WHERE filename = '" + filename + "'";
            SQLiteCommand command = new SQLiteCommand(sql, con);
            command.ExecuteNonQuery();
        }

        public SQLiteDataReader GetOrdered(string order = "score", string type = "DESC") {
            string sql = "SELECT * FROM music ORDER BY " + order + " " + type;
            SQLiteCommand command = new SQLiteCommand(sql, con);
            SQLiteDataReader reader = command.ExecuteReader();
            return reader;
        }
        //!!close db connection on form exit
    }
}
