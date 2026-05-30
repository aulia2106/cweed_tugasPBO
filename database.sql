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
    target_kg DECIMAL(10, 2) NOT NULL,
    deadline DATE NOT NULL,
    id_user INT, 
    PRIMARY KEY (id_demand),
    FOREIGN KEY (id_user) REFERENCES usser(id_user) ON DELETE SET NULL ON UPDATE CASCADE
);

-- LEBOKNE ISI DATANE 
INSERT INTO usser (nama, no_hp, username, passwd, status_konfir_akun, role_pilihan)
VALUES
('james', '11111111', 'Zhao_yufan', 'jamesgantenk', 'Konfirmasi', 'NELAYAN'),
('martin', '22222222', 'Martin_Edward', 'mybojogwehnei', 'Konfirmasi', 'ADMIN'),
('juhoon', '33333333', 'Kim_Juhoon', 'juhoonjenggawah', 'Konfirmasi', 'ADMIN'),
('seonghyeon', '44444444', 'Eom_Eeonghyeon', 'kerenkmuseong', 'Konfirmasi', 'NELAYAN'),
('keonho', '55555555', 'Ahn_Keonho', 'konoplayerepep', 'Konfirmasi', 'DISTRIBUTOR')
