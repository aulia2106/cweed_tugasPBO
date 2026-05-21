-- 1. HAPUS TABEL (Urutan benar agar tidak bentrok Foreign Key)
DROP TABLE IF EXISTS stok_rumput_laut;
DROP TABLE IF EXISTS nelayan;
DROP TABLE IF EXISTS pengguna;

select * from nelayan

-- 2. BUAT TABEL PENGGUNA (Untuk Akun & Login)
CREATE TABLE nelayan (
    id_nelayan SERIAL PRIMARY KEY,
    nama_nelayan VARCHAR(100) NOT NULL,
    nomor_HP VARCHAR(15),
    username VARCHAR(50) NOT NULL UNIQUE, -- UNIQUE menjamin username tidak boleh kembar
    sandi VARCHAR(255) NOT NULL
);

-- 3. BUAT TABEL STOK RUMPUT LAUT
CREATE TABLE stok_rumput_laut (
    id_stok SERIAL PRIMARY KEY,
    jenis_rumput_laut VARCHAR(100) NOT NULL,
    stok_kg INT NOT NULL CHECK (stok_kg >= 0),
    tanggal_input DATE DEFAULT CURRENT_DATE,
    id_nelayan INT,
    FOREIGN KEY (id_nelayan) REFERENCES nelayan(id_nelayan) ON DELETE SET NULL
);


-- ==========================================================
-- INSERT DATA CONTOH
-- ==========================================================

-- 4. INSERT DATA PENGGUNA (NELAYAN)
INSERT INTO nelayan (nama_nelayan, nomor_HP, username, sandi)
VALUES
('Cipis', '081234567890', 'Cipis_sibuk123', 'rahasiaCipis123'),
('Gimbul', '087766554433', 'Gimbul_pemalas123', 'rahasiaGimbul456');

-- *Tes Error Username Sama* -- (Kalau baris di bawah ini dijalankan, database akan otomatis menolak/error)
-- INSERT INTO pengguna (nama_lengkap, nomor_hp, username, password) 
-- VALUES ('Budi Palsu', '0811111111', 'budi_laut', 'passwordSama'); 


-- 5. INSERT DATA STOK RUMPUT LAUT
-- Kita masukkan stok dengan menghubungkannya ke id_pengguna yang menyetor
-- INSERT DATA STOK RUMPUT LAUT (Variasi Internasional)
INSERT INTO stok_rumput_laut (jenis_rumput_laut, stok_kg, tanggal_input, id_nelayan)
VALUES
-- Jepang 🇯🇵
('Nori (Pyropia)', 150, '2026-05-18', 1), 
('Wakame (Undaria pinnatifida)', 85, '2026-05-18', 2),
('Kombu (Saccharina japonica)', 210, '2026-05-19', 1),
('Dulse (Palmaria palmata)', 90, '2026-05-20', 2);