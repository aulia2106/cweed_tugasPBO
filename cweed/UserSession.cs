using System;

namespace cweed
{
    public static class UserSession
    {
        // Tempat menyimpan username (opsional, jika nanti butuh)
        public static int id_nelayan_masuk { get; set; }
        public static string username_masuk { get; set; }
        public static string username_daftar { get; set; }

        // wadah inilah yang akan menampung nama asli hasil tarikan dari DB atau TextBox daftar
        public static string nama_nelayan_masuk { get; set; }
    }
}