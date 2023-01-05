CREATE DATABASE musorok;
USE musorok;

CREATE TABLE filmek (
    id INTEGER IDENTITY(1,1) PRIMARY KEY,
    cime VARCHAR(50) NOT NULL,
    leirasa VARCHAR(255) NOT NULL,
    mufaja VARCHAR(25) NOT NULL,
    kiadas_eve INTEGER NOT NULL,
    borito_path VARCHAR(100) NOT NULL
);

CREATE TABLE szereplok
(
    id INTEGER IDENTITY(1,1) PRIMARY KEY,
    musor_id INTEGER NOT NULL,
    cime VARCHAR(50) NOT NULL,
    szereplo VARCHAR(50) NOT NULL,
    szuletesiev INTEGER NOT NULL
);

INSERT INTO musorok (cime, leirasa, mufaja, kiadas_eve, borito_path) 
VALUES ('Másnaposok', 'Az éjszaka után döbbenten ébrednek, egy társuk eltűnt.', 'Vígjáték', '2009', 'masnaposok.jpg'),
('Torrente', 'Torrente, a törvény két balkeze', 'Vígjáték', '1998', 'torrente.jpg'),
('Forrest Gump', 'Egy déli államokbeli fiú, Forrest Gump rögös életútjáról szól a történet.', 'Tragikomédia', '1994', 'forrest.jpg'),
('Schindler listája', 'Egyetlen ember is képes lehet arra, hogy a körülmények ellenére megváltoztassa a dolgok menetét', 'Dráma', '1993', 'schindler.jpg'),
('Interstellar', 'In the future, a farmer and ex-NASA pilot, Joseph Cooper, is tasked to pilot a spacecraft.', 'Sci-fi', '2014', 'interstellar.jpg'),
('Haverok harca', 'Pár iskolás barát elhatározza, hogy felnőtt korukban is fogócskázni fognak.', 'Vígjáték', '2018', 'hh.jpg'),
('A diktátor', 'Az elpusztíthatatlan szakállú Aladdin, mindent megtesz azért, hogy a demokrácia be ne tehesse lábát országába', 'Vígjáték', '2012', 'diktator.jpg'),
('Borat', 'Borat: Kazah nép nagy fehér gyermeke menni művelődni Amerika', 'Vígjáték', '2006', 'borat.jpg'),
('V mint vérbosszú', 'Ne kérdezz, ne kritizálj, ne is gondolkodj: a Párt mindent jobban tud.', 'Akciófilm', '2005', 'vmint.jpg'),
('Mátrix', 'Ahogy látjuk: Szürke, egyhangú világunk valóságos.', 'Sci-fi', '1999', 'matrix.jpg'),
('Jupiter felemelkedése', 'Jupiter Jones éjszaka született, és a jelek az mutatták, kivételesen nagy jövő áll előtte. Ám ez a jövő nem akar megérkezni.', 'Sci-fi', '2015', 'jupiter.jpg'),
('Szólíts a neveden', 'Egy nyár Észak-Olaszországban. Elio, a 17 éves amerikai srác számára maga a paradicsom.', 'Romantikus dráma', '2017', 'szolaneveden.jpg');

-- Minden filmhez hozzátársított főszereplő
INSERT INTO szereplok (musor_id, cime, szereplo, szuletesiev) 
VALUES ('1', 'Másnaposok', 'Bradley Cooper', '1975'),
 ('2', 'Torrente', 'Santiago Segura', '1965'),
 ('3', 'Forrest Gump', 'Tom Hanks', '1956'),
 ('4', 'Schindler listája', 'Liam Neeson', '1952'),
 ('5', 'Interstellar', 'Matthew David McConaughey', '1969'),
 ('6', 'Haverok harca', 'Ed Helms', '1974'),
 ('7', 'A diktátor', 'Sacha Baron Cohen', '1971'),
 ('8', 'Borat', 'Sacha Baron Cohen', '1971'),
 ('9', 'V mint vérbosszú', 'Natalie Portman', '1981'),
 ('10', 'Mátrix', 'Laurence Fishburne', '1961'),
 ('11', 'Jupiter felemelkedése', 'Mila Kunis', '1983'),
 ('11', 'Szólíts a neveden', 'Timothée Chalamet', '1995');