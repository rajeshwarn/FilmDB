CREATE TABLE "Film" 
(
	"ID" INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL UNIQUE, 
	"Titel" VARCHAR, 
	"Omschrijving" VARCHAR, 
	"IMDBCijfer" VARCHAR, 
	"IMDBLink" VARCHAR, 
	"Historisch" BOOL, 
	"Afgewezen" BOOL, 
	"Released" BOOL
);

CREATE TABLE "Serie" 
(
	"ID" INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL UNIQUE, 
	"Titel" VARCHAR, 
	"Omschrijving" VARCHAR, 
	"IMDBCijfer" VARCHAR, 
	"IMDBLink" VARCHAR, 
	"Historisch" BOOL, 
	"Afgewezen" BOOL, 
	"Huidig" BOOL,
	"HuidigSeizoen" INTEGER,
	"HuidigSeizoenKlaar" BOOL,
	"HuidigAflevering" INTEGER,
	"Komedie" BOOL
);

CREATE TABLE "Instelling" 
(
	"ID" INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
	"Setting" VARCHAR, 
	"Waarde" VARCHAR
);

INSERT INTO "Instelling" VALUES (1, 'Versie', '1');

