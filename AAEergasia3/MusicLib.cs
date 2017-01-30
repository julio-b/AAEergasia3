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
            string sql = "CREATE TABLE IF NOT EXISTS music (filename TEXT, song TEXT, artist TEXT, year INT, genre TEXT, language TEXT, score INT, UNIQUE(filename))";
            SQLiteCommand command = new SQLiteCommand(sql, con);
            command.ExecuteNonQuery();
        }

        public void InsertNewFile(string filename, string song, string artist, int year, string genre, string language = "English", int score=0) {
            filename = filename.Replace("'", "''");
            song = song.Replace("'", "''");
            artist = artist.Replace("'", "''");
            genre = genre.Replace("'", "''");
            language = language.Replace("'", "''");
            string sql = "INSERT OR IGNORE INTO music (filename, song, artist, year, genre, language, score) VALUES ("
                + "'"    + filename
                + "','"  + song
                + "', '" + artist
                + "',"   + year
                + ",'"   + genre
                + "','"  + language
                + "',"   + score
                + ")";
            SQLiteCommand command = new SQLiteCommand(sql, con);
            command.ExecuteNonQuery();
        }

        public void DeleteFile(string filename) {
            filename = filename.Replace("'", "''");
            string sql = "DELETE FROM music WHERE filename = '" + filename + "'";
            SQLiteCommand command = new SQLiteCommand(sql, con);
            command.ExecuteNonQuery();
        }

        public void EditFileInfos(string filename, string column, string value) {
            filename = filename.Replace("'", "''");
            value = value.Replace("'", "''");
            string sql = "UPDATE music SET " + column + "= '" + value + "' WHERE filename = '" + filename + "'";
            SQLiteCommand command = new SQLiteCommand(sql, con);
            command.ExecuteNonQuery();
        }
        public void EditFileInfos(string filename, string column, int value) {
            filename = filename.Replace("'", "''");
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

        public void Close() {
            con.Close();
        }
    }
}
