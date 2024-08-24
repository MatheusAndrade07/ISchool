CREATE DATABASE saep_db;


USE saep_db;

CREATE TABLE Professor 
(
    IdProfessor INT IDENTITY(1,1) PRIMARY KEY,
    Nome VARCHAR(100) NOT NULL,
    Email VARCHAR(100) NOT NULL UNIQUE,
    Senha VARCHAR(255) NOT NULL
);


CREATE TABLE Turma 
(
    IdTurma INT IDENTITY(1,1) PRIMARY KEY,
    NomeTurma VARCHAR(100) NOT NULL,
    IdProfessor INT NOT NULL,
    FOREIGN KEY (IdProfessor) REFERENCES Professor(IdProfessor)
);


CREATE TABLE Atividade 
(
    IdAtividade INT IDENTITY(1,1) PRIMARY KEY,
    Descricao VARCHAR(255) NOT NULL,
    IdTurma INT NOT NULL,
    FOREIGN KEY (IdTurma) REFERENCES Turma(IdTurma)
);


INSERT INTO Professor (Nome, Email, Senha) VALUES
    ('Jo�o da Silva', 'joao.silva@email.com', '123456'),
    ('Maria da Costa', 'maria.costa@email.com', 'qwerty'),
    ('Pedro Rodrigues', 'pedro.rodrigues@email.com', 'password');


INSERT INTO Turma (NomeTurma, IdProfessor) VALUES
    ('Turma A', 1),
    ('Turma B', 2),
    ('Turma C', 3);


INSERT INTO Atividade (Descricao, IdTurma) VALUES
    ('Trabalho de pesquisa sobre a hist�ria da computa��o', 1),
    ('Apresenta��o sobre linguagem de programa��o Python', 2),
    ('Exerc�cios pr�ticos de desenvolvimento web', 3);