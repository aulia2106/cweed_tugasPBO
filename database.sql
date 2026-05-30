-- BUAT TABEL E SEK
CREATE TYPE tipe_role AS ENUM ('ADMIN', 'DISTRIBUTOR', 'NELAYAN');

CREATE TABLE usser (
    id_user SERIAL,
    nama VARCHAR(100) NOT NULL,
    no_hp VARCHAR(20),
    username VARCHAR(10) NOT NULL UNIQUE,
    passwd VARCHAR(10) NOT NULL, 
    status_konfir_akun VARCHAR(10),
    role_pilihan tipe_role NOT NULL, 
    PRIMARY KEY (id_user)
);

CREATE TABLE demand (
    id_demand SERIAL,
    target_kg NUMERIC(10, 2) NOT NULL,
    deadline DATE NOT NULL,
    id_user INT, 
    PRIMARY KEY (id_demand),
    FOREIGN KEY (id_user) REFERENCES usser(id_user) ON DELETE SET NULL ON UPDATE CASCADE
);

CREATE TABLE grade (
    id_grade SERIAL,
    kategori VARCHAR(50) NOT NULL, 
    keterangan TEXT,               
    harga_per_kg INT NOT NULL,     
    PRIMARY KEY (id_grade)
);

CREATE TABLE transaksi (
    id_transaksi SERIAL,
    tanggal DATE NOT NULL,
    status_transaksi VARCHAR(50) NOT NULL, 
    total_pembayaran INT NOT NULL,        
    id_user INT,                           
    PRIMARY KEY (id_transaksi),
    FOREIGN KEY (id_user) REFERENCES usser(id_user) ON DELETE SET NULL ON UPDATE CASCADE
);

CREATE TABLE keranjang (
    id_keranjang SERIAL,
    jumlah_per_kg NUMERIC(10, 2) NOT NULL, 
    subtotal INT NOT NULL,                 
    id_transaksi INT NOT NULL,             
    id_grade INT NOT NULL,                 
    id_nelayan INT NOT NULL,               
    PRIMARY KEY (id_keranjang),
    FOREIGN KEY (id_transaksi) REFERENCES transaksi(id_transaksi) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY (id_grade) REFERENCES grade(id_grade) ON DELETE RESTRICT ON UPDATE CASCADE,
    FOREIGN KEY (id_nelayan) REFERENCES usser(id_user) ON DELETE RESTRICT ON UPDATE CASCADE
);

-- LEBOKNE ISI DATANE 
INSERT INTO usser (nama, no_hp, username, passwd, status_konfir_akun, role_pilihan)
VALUES
('james', '11111111', 'Zhao_yufan', 'jamesgantenk', 'Konfirmasi', 'NELAYAN'),
('martin', '22222222', 'Martin_Edward', 'mybojogwehnei', 'Konfirmasi', 'ADMIN'),
('juhoon', '33333333', 'Kim_Juhoon', 'juhoonjenggawah', 'Konfirmasi', 'ADMIN'),
('seonghyeon', '44444444', 'Eom_Eeonghyeon', 'kerenkmuseong', 'Konfirmasi', 'NELAYAN'),
('keonho', '55555555', 'Ahn_Keonho', 'konoplayerepep', 'Konfirmasi', 'DISTRIBUTOR')

INSERT INTO grade (kategori, keterangan, harga_per_kg) VALUES
('Grade A', 'Kering sempurna, bersih dari kotoran', 50000),
('Grade B', 'Kadar air sedang, sedikit rumput liar', 35000),
('Grade C', 'Lembab/basah, perlu dijemur ulang', 20000);
