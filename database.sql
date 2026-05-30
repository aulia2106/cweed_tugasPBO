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
