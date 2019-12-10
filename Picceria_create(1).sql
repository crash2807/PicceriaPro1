-- Created by Vertabelo (http://vertabelo.com)
-- Last modification date: 2019-12-10 22:28:39.547

-- tables
-- Table: Administrator
CREATE TABLE Administrator (
    idAdmina int  NOT NULL,
    imie varchar(20)  NOT NULL,
    nazwisko varchar(50)  NOT NULL,
    login varchar(20)  NOT NULL,
    hasloAdmina varchar(20)  NOT NULL,
    CONSTRAINT Administrator_pk PRIMARY KEY  (idAdmina)
);

-- Table: Klient
CREATE TABLE Klient (
    idKlienta int  NOT NULL,
    imie varchar(20)  NOT NULL,
    nazwisko varchar(50)  NOT NULL,
    login varchar(20)  NULL,
    hasloKlienta varchar(20)  NULL,
    adresEmail varchar(100)  NULL,
    CONSTRAINT Klient_pk PRIMARY KEY  (idKlienta)
);

-- Table: Klient_Zamowienie
CREATE TABLE Klient_Zamowienie (
    idKlienta int  NOT NULL,
    idZamowienia int  NOT NULL,
    CONSTRAINT Klient_Zamowienie_pk PRIMARY KEY  (idKlienta,idZamowienia)
);

-- Table: Napoj
CREATE TABLE Napoj (
    idNapoju int  NOT NULL,
    nazwaNapoju varchar(20)  NOT NULL,
    cenaNapoju money  NOT NULL,
    CONSTRAINT Napoj_pk PRIMARY KEY  (idNapoju)
);

-- Table: Napoj_Zamowienie
CREATE TABLE Napoj_Zamowienie (
    idNapoju int  NOT NULL,
    idZamowienia int  NOT NULL,
    CONSTRAINT Napoj_Zamowienie_pk PRIMARY KEY  (idNapoju,idZamowienia)
);

-- Table: Picca
CREATE TABLE Picca (
    idPiccy int  NOT NULL,
    nazwaPiccy varchar(20)  NOT NULL,
    rozmiar decimal(3,1)  NOT NULL,
    cenaPiccy money  NOT NULL,
    CONSTRAINT Picca_pk PRIMARY KEY  (idPiccy)
);

-- Table: Picca_Skladniki
CREATE TABLE Picca_Skladniki (
    idPiccy int  NOT NULL,
    idSkladnika int  NOT NULL,
    CONSTRAINT Picca_Skladniki_pk PRIMARY KEY  (idPiccy,idSkladnika)
);

-- Table: Pracownik
CREATE TABLE Pracownik (
    idPracownika int  NOT NULL,
    imie varchar(20)  NOT NULL,
    nazwisko varchar(50)  NOT NULL,
    login varchar(20)  NOT NULL,
    hasloPracownika varchar(20)  NOT NULL,
    idAdmina int  NOT NULL,
    CONSTRAINT Pracownik_pk PRIMARY KEY  (idPracownika)
);

-- Table: Pracownik_Zamowienie
CREATE TABLE Pracownik_Zamowienie (
    idPracownika int  NOT NULL,
    idZamowienia int  NOT NULL,
    CONSTRAINT Pracownik_Zamowienie_pk PRIMARY KEY  (idPracownika,idZamowienia)
);

-- Table: Skladniki
CREATE TABLE Skladniki (
    idSkladnika int  NOT NULL,
    nazwaSkladnika varchar(20)  NOT NULL,
    cenaSkladnika money  NULL,
    CONSTRAINT Skladniki_pk PRIMARY KEY  (idSkladnika)
);

-- Table: Sos
CREATE TABLE Sos (
    idSosu int  NOT NULL,
    nazwaSosu int  NOT NULL,
    cenaSosu money  NOT NULL,
    CONSTRAINT Sos_pk PRIMARY KEY  (idSosu)
);

-- Table: Sos_Zamowienie
CREATE TABLE Sos_Zamowienie (
    idSosu int  NOT NULL,
    idZamowienia int  NOT NULL,
    CONSTRAINT Sos_Zamowienie_pk PRIMARY KEY  (idSosu,idZamowienia)
);

-- Table: StanZamowienia
CREATE TABLE StanZamowienia (
    idStanu int  NOT NULL,
    nazwaStanu varchar(20)  NOT NULL,
    CONSTRAINT StanZamowienia_pk PRIMARY KEY  (idStanu)
);

-- Table: Zamowienie
CREATE TABLE Zamowienie (
    idZamowienia int  NOT NULL,
    dataZamowienia datetime  NOT NULL,
    dataRealizacji datetime  NOT NULL,
    adres varchar(200)  NOT NULL,
    idStanu int  NOT NULL,
    idPiccy int  NOT NULL,
    CONSTRAINT Zamowienie_pk PRIMARY KEY  (idZamowienia)
);

-- foreign keys
-- Reference: Picca_Skladniki_Picca (table: Picca_Skladniki)
ALTER TABLE Picca_Skladniki ADD CONSTRAINT Picca_Skladniki_Picca
    FOREIGN KEY (idPiccy)
    REFERENCES Picca (idPiccy);

-- Reference: Picca_Skladniki_Skladniki (table: Picca_Skladniki)
ALTER TABLE Picca_Skladniki ADD CONSTRAINT Picca_Skladniki_Skladniki
    FOREIGN KEY (idSkladnika)
    REFERENCES Skladniki (idSkladnika);

-- Reference: Pracownik_Administrator (table: Pracownik)
ALTER TABLE Pracownik ADD CONSTRAINT Pracownik_Administrator
    FOREIGN KEY (idAdmina)
    REFERENCES Administrator (idAdmina);

-- Reference: Pracownik_Zamowienie (table: Pracownik_Zamowienie)
ALTER TABLE Pracownik_Zamowienie ADD CONSTRAINT Pracownik_Zamowienie
    FOREIGN KEY (idZamowienia)
    REFERENCES Zamowienie (idZamowienia);

-- Reference: Sos_Zamowienie_Sos (table: Sos_Zamowienie)
ALTER TABLE Sos_Zamowienie ADD CONSTRAINT Sos_Zamowienie_Sos
    FOREIGN KEY (idSosu)
    REFERENCES Sos (idSosu);

-- Reference: Sos_Zamowienie_Zamowienie (table: Sos_Zamowienie)
ALTER TABLE Sos_Zamowienie ADD CONSTRAINT Sos_Zamowienie_Zamowienie
    FOREIGN KEY (idZamowienia)
    REFERENCES Zamowienie (idZamowienia);

-- Reference: Table_10_Klient (table: Klient_Zamowienie)
ALTER TABLE Klient_Zamowienie ADD CONSTRAINT Table_10_Klient
    FOREIGN KEY (idKlienta)
    REFERENCES Klient (idKlienta);

-- Reference: Table_10_Zamowienie (table: Klient_Zamowienie)
ALTER TABLE Klient_Zamowienie ADD CONSTRAINT Table_10_Zamowienie
    FOREIGN KEY (idZamowienia)
    REFERENCES Zamowienie (idZamowienia);

-- Reference: Table_11_Napoj (table: Napoj_Zamowienie)
ALTER TABLE Napoj_Zamowienie ADD CONSTRAINT Table_11_Napoj
    FOREIGN KEY (idNapoju)
    REFERENCES Napoj (idNapoju);

-- Reference: Table_11_Zamowienie (table: Napoj_Zamowienie)
ALTER TABLE Napoj_Zamowienie ADD CONSTRAINT Table_11_Zamowienie
    FOREIGN KEY (idZamowienia)
    REFERENCES Zamowienie (idZamowienia);

-- Reference: Table_15_Pracownik (table: Pracownik_Zamowienie)
ALTER TABLE Pracownik_Zamowienie ADD CONSTRAINT Table_15_Pracownik
    FOREIGN KEY (idPracownika)
    REFERENCES Pracownik (idPracownika);

-- Reference: Zamowienie_Picca (table: Zamowienie)
ALTER TABLE Zamowienie ADD CONSTRAINT Zamowienie_Picca
    FOREIGN KEY (idPiccy)
    REFERENCES Picca (idPiccy);

-- Reference: Zamowienie_StanZamowienia (table: Zamowienie)
ALTER TABLE Zamowienie ADD CONSTRAINT Zamowienie_StanZamowienia
    FOREIGN KEY (idStanu)
    REFERENCES StanZamowienia (idStanu);

-- End of file.

