namespace UTS_Lanjutan_AgusRH.Models
{
    public class Genre
    {
        public Buku GetBuku { get; set; }
        public Genre(Buku buku) 
        {
            GetBuku = buku;
        }

        public string Book
        {
            get
            {
                string getgenre = "";
                if(GetBuku == Buku.Komik_Black_Clover || GetBuku == Buku.Komik_Jujutsu_Kaisen || GetBuku == Buku.Komik_One_Piece)
                {
                    getgenre = "Komik";
                }
                else if(GetBuku == Buku.Novel_Andrea_Hirata || GetBuku == Buku.Novel_JK_Rowling || GetBuku == Buku.Novel_Tere_Liye)
                {
                    getgenre = "Novel";
                }
                else if(GetBuku == Buku.Sejarah_Indonesia || GetBuku == Buku.Sejarah_Yunani || GetBuku == Buku.Sejarah_Jepang)
                {
                    getgenre = "Sejarah";
                }
                return getgenre;
            }
        }
    }
}
