CREATE TABLE departamentas (
departamentas_id serial PRIMARY KEY,
departamentas_name VARCHAR (50) NOT NULL,
studentas_id int,
paskaita_id int,
FOREIGN KEY (studentas_id) REFERENCES studentas (studentas_id),
FOREIGN KEY (paskaita_id) REFERENCES paskaita (paskaita_id)
)
CREATE TABLE studentas (
studentas_id serial PRIMARY KEY,
studentas_name VARCHAR (50) NOT NULL,
studentas_lastname VARCHAR (50) NOT NULL,
departamentas_id int,
paskaita_id int,
FOREIGN KEY (departamentas_id) REFERENCES departamentas (departamentas_id),
)
CREATE TABLE paskaita (
paskaita_id serial PRIMARY KEY,
paskaita_name VARCHAR (50) NOT NULL,
departamentas_id int,
FOREIGN KEY (departamentas_id) REFERENCES departamentas (departamentas_id)
)
