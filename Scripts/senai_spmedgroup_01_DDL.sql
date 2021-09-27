CREATE DATABASE SPCLINICALGROUP
GO

USE SPCLINICALGROUP
GO

CREATE TABLE CLINICA(
idClinica TINYINT PRIMARY KEY IDENTITY,
NomeClinica VARCHAR(20) UNIQUE NOT NULL,
CNPJ CHAR(18)  UNIQUE NOT NULL,
RazaoSocial VARCHAR(200),
Endereco VARCHAR(100) NOT NULL,
)
GO

CREATE TABLE ESPECIALIDADE(
idEspecialidade TINYINT PRIMARY KEY IDENTITY,
Especialidade VARCHAR(35) UNIQUE NOT NULL,
)
GO

CREATE TABLE SITUACAO(
idSituacao TINYINT PRIMARY KEY IDENTITY,
Situacao VARCHAR(10) UNIQUE NOT NULL,
)
GO

CREATE TABLE TipoUsuario(
idTipoUsuario TINYINT PRIMARY KEY IDENTITY,
Tipo VARCHAR(13) UNIQUE NOT NULL,
)
GO

CREATE TABLE PACIENTE(
idPaciente INT PRIMARY KEY IDENTITY(1,1),
DataNasc VARCHAR(10) NOT NULL,
Telefone VARCHAR(13) UNIQUE,
RG CHAR(10) UNIQUE NOT NULL,
CPF CHAR(11) UNIQUE NOT NULL,
Endereco VARCHAR(100) NOT NULL,
)
GO

CREATE TABLE MEDICO(
idMedico SMALLINT PRIMARY KEY IDENTITY,
CRM CHAR(8) UNIQUE NOT NULL,
idClinica TINYINT FOREIGN KEY REFERENCES CLINICA(idClinica),
idEspecialidade TINYINT FOREIGN KEY REFERENCES ESPECIALIDADE(idEspecialidade),
)
GO

CREATE TABLE USUARIO(
idUsuario INT PRIMARY KEY IDENTITY,
Nome VARCHAR(50) NOT NULL,
Email VARCHAR(256) UNIQUE NOT NULL,
Senha VARCHAR(16),
idTipoUsuario TINYINT FOREIGN KEY REFERENCES TipoUsuario(idTipoUsuario),
idPaciente INT FOREIGN KEY REFERENCES PACIENTE(idPaciente),
idMedico SMALLINT FOREIGN KEY REFERENCES MEDICO(idMedico),
)
GO

CREATE TABLE CONSULTA(
idConsulta INT PRIMARY KEY IDENTITY,
idPaciente INT FOREIGN KEY REFERENCES PACIENTE(idPaciente) NOT NULL,
idMedico SMALLINT FOREIGN KEY REFERENCES MEDICO(idMedico) NOT NULL,
DataConsulta CHAR(10) NOT NULL,
idSituacao TINYINT FOREIGN KEY REFERENCES SITUACAO(idSituacao) NOT NULL,
)
GO

