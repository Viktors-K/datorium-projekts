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
  email TEXT UNIQUE NOT NULL,
  password_hash TEXT NOT NULL,
  admin BOOLEAN NOT NULL DEFAULT 0,
  profile_data JSON
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
INSERT INTO Users (username, email, password_hash, admin, profile_data)
VALUES ('vvkocetoks', 'vvkocetoks@edu.riga.lv', '$2a$12$wH9WqjzXfIS0JbHtv37Zo.GfdJzF.dFq2lAmgOQyU27MTeFg3.kz6', 1,
        '{"name": "Viktors", "surname": "Kočetoks", "class": "12.EI"}'
);
INSERT INTO Users (username, email, password_hash, admin, profile_data)
VALUES ('mpunans', 'mpunans@edu.riga.lv', '$2a$12$OYn2nQh3GG1RO3lh1/zBz.vR5TO8m2gdtTyE/mMwnz6eyYtTzJzzm', 0,
        '{"name": "Markuss", "surname": "Punāns", "class": "12.EI"}'
);
INSERT INTO Users (username, email, password_hash, admin, profile_data)
VALUES ('esulcs13', 'esulcs13@edu.riga.lv', '$2a$12$XbNq.Vx5zj6Hnn5BB7Xjw.x2mjBQw2R9xoXzD8U1a9P.WaK3eGFEq', 0,
        '{"name": "Emīls", "surname": "Šulcs", "class": "12.EI"}'
);

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
SELECT * FROM Users;
