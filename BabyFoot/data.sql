CREATE DATABASE babyfoot;

CREATE TABLE personne(
	id SERIAL PRIMARY KEY,
	nom VARCHAR,
	montant FLOAT
);

CREATE TABLE jeu(
	id SERIAL PRIMARY KEY,
	idJ1 INTEGER,
	idJ2 INTEGER,
	FOREIGN KEY (idJ1) REFERENCES personne(id),
	FOREIGN KEY (idJ2) REFERENCES personne(id)
);

CREATE TABLE gain(
	id SERIAL PRIMARY KEY,
	idJeu INTEGER,
	idTerrain INTEGER,
	gainTerrain FLOAT,
	idJ1 INTEGER,
	gainJ1 FLOAT,
	idJ2 INTEGER,
	gainJ2 FLOAT,
	FOREIGN KEY (idJeu) REFERENCES jeu(id),
	FOREIGN KEY (idTerrain) REFERENCES personne(id),
	FOREIGN KEY (idJ1) REFERENCES personne(id),
	FOREIGN KEY (idJ2) REFERENCES personne(id)
);

INSERT INTO personne VALUES(default,'Terrain',0),(default,'Joueur1',5000),(default,'Joueur2',5000);
