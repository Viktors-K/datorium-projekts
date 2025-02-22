-- Datoru izsniegšanas sistēma
-- Viktors Kočetoks, Markuss Punāns, Emīls Šulcs 
-- 12. EI klase, Rīgas Valsts vācu ģimnāzija

-- Veco tabulu noņemšana koda pārbaudei sqliteonline.com
DROP TABLE IF EXISTS demo;
DROP TABLE IF EXISTS Handouts;
DROP TABLE IF EXISTS Items;
DROP TABLE IF EXISTS Users;
DROP TABLE IF EXISTS Reservations;

-- Tabulu izveide
CREATE TABLE IF NOT EXISTS Users (
  id INTEGER PRIMARY KEY AUTOINCREMENT,
  username TEXT NOT NULL UNIQUE,
  name TEXT NOT NULL,
  surname TEXT NOT NULL,
  class TEXT NOT NULL
);

CREATE TABLE IF NOT EXISTS Items (
  id INTEGER PRIMARY KEY AUTOINCREMENT,
  type TEXT NOT NULL,
  details TEXT
);

CREATE TABLE IF NOT EXISTS Handouts (
  id INTEGER PRIMARY KEY AUTOINCREMENT,
  item_id INTEGER NOT NULL,
  username TEXT NOT NULL,
  issued_at TEXT NOT NULL,
  due_at TEXT NOT NULL,
  returned_at TEXT,
  FOREIGN KEY (item_id) REFERENCES Items(id),
  FOREIGN KEY (username) REFERENCES Users(username)
);
CREATE TABLE IF NOT EXISTS Reservations (
  id INTEGER PRIMARY KEY AUTOINCREMENT,
  item_id INTEGER NOT NULL,
  username TEXT NOT NULL,
  reserved_from TEXT NOT NULL,
  reserved_until TEXT NOT NULL,
  status TEXT NOT NULL,
  FOREIGN KEY (item_id) REFERENCES Items(id),
  FOREIGN KEY (username) REFERENCES Users(username)
);

-- Sākuma datu izveide
INSERT INTO Users(username, name, surname, class) 
VALUES ('vvkocetoks', 'Viktors', 'Kočetoks', '12.EI');
INSERT INTO Users(username, name, surname, class) 
VALUES ('mpunans', 'Markuss', 'Punāns', '12.EI');
INSERT INTO Users(username, name, surname, class) 
VALUES ('esulcs13', 'Emīls', 'Šulcs', '12.EI');

INSERT INTO Items(type, details) 
VALUES ('Laptop', 'Windows OS');
INSERT INTO Items(type, details) 
VALUES ('Charger', '9V adapter');
INSERT INTO Items(type, details) 
VALUES ('Mouse', 'USB-A');

INSERT INTO Handouts(item_id, username, issued_at, due_at, returned_at) 
VALUES ('2', 'vvkocetoks', '08:37 11.02.2025', '12:20 11.02.2025', '12:17 11.02.2025');
INSERT INTO Handouts(item_id, username, issued_at, due_at, returned_at) 
VALUES ('1', 'vvkocetoks', '08:37 11.02.2025', '12:20 11.02.2025', '12:17 11.02.2025');
INSERT INTO Handouts(item_id, username, issued_at, due_at, returned_at) 
VALUES ('3', 'vvkocetoks', '08:37 11.02.2025', '12:20 11.02.2025', '12:17 11.02.2025');

INSERT INTO Reservations(item_id, username, reserved_from, reserved_until, status) 
VALUES ('1', 'esulcs13', '10:00 12.02.2025', '12:00 12.02.2025', 'active');
INSERT INTO Reservations(item_id, username, reserved_from, reserved_until, status) 
VALUES ('2', 'vvkocetoks', '14:00 12.02.2025', '16:00 12.02.2025', 'cancelled');
INSERT INTO Reservations(item_id, username, reserved_from, reserved_until, status) 
VALUES ('3', 'mpunans', '09:00 13.02.2025', '11:00 13.02.2025', 'completed');

-- Izsniegumu tabulas izvade pārbaudei sqliteonline.com
SELECT * FROM Handouts;
