use CBDA

create table Equipes(
ID_Equipe int primary key identity,
Nome varchar(30) unique not null,
Cidade_Sede varchar(30) not null,
Data_Fundacao date not null,
Numero_Campeonato smallint default 0,
Numero_Titulo smallint default 0
)

create table Tipos_Telefones(
ID_Tipo_Telefone tinyint primary key identity,
Tipo varchar(15) unique not null
)

create table Medalhas(
ID_Medalha tinyint primary key identity,
Tipo varchar(10) unique not null
)

create table Campeonatos(
ID_Campeonato smallint primary key identity,
Nome varchar(30) not null,
Cidade varchar(30) not null,
Ano_Edicao smallint unique not null,
Data_Inicio date not null,
Data_Termino date not null
)

create table Estilos(
ID_Estilo tinyint primary key identity,
Nome varchar(20) unique not null
)

create table Sexos(
ID_Sexo tinyint primary key identity,
Sexo varchar(15) unique not null
)

create table Pessoas(
ID_Pessoa int primary key identity,
ID_Equipe int not null constraint fk_Equipe_Pessoa foreign key(ID_Equipe) references Equipes(ID_Equipe),
Numero_Matricula int unique not null,
Nome varchar(30) not null
)

create table Treinadores(
ID_Treinador int primary key identity,
ID_Pessoa int not null constraint fk_Pessoa_Treinador foreign key(ID_Pessoa) references Pessoas(ID_Pessoa),
Numero_Titulo smallint default 0,
Formacao_Academica varchar(30) not null
)

create table Nadadores(
ID_Nadador int primary key identity,
ID_Pessoa int not null constraint fk_Pessoa_Nadador foreign key(ID_Pessoa) references Pessoas(ID_Pessoa),
ID_Sexo tinyint not null constraint fk_Sexo_Nadador foreign key(ID_Sexo) references Sexos(ID_Sexo),
Data_Inscricao datetime not null,
Email varchar(40) unique not null,
Numero_Campeonato smallint default 0,
Data_Nascimento date not null
)

create table Provas(
ID_Prova int primary key identity,
ID_Sexo tinyint not null constraint fk_Sexo_Prova foreign key(ID_Sexo) references Sexos(ID_Sexo),
ID_Estilo tinyint not null constraint fk_Estilo_Prova foreign key(ID_Estilo) references Estilos(ID_Estilo),
Distancia smallint not null constraint un_Distancia_Estilo_Sexo unique(Distancia, ID_Estilo, ID_Sexo)
)

create table Recordes(
ID_Recorde int primary key identity,
ID_Nadador int not null constraint fk_Nadador_Recorde foreign key(ID_Nadador) references Nadadores(ID_Nadador),
ID_Prova int not null constraint fk_Prova_Recorde foreign key(ID_Prova) references Provas(ID_Prova),
Data date not null,
Tempo smallint not null
)

create table Telefones_Nadadores(
ID_Nadador int not null constraint fk_Nadador_Telefone foreign key(ID_Nadador) references Nadadores(ID_Nadador),
ID_Tipo_Telefone tinyint not null constraint fk_Tipo_Telefone foreign key(ID_Tipo_Telefone) references Tipos_Telefones(ID_Tipo_Telefone),
Numero bigint unique not null
)

create table Provas_Campeonatos(
ID_Prova_Campeonato int primary key identity,
ID_Campeonato smallint not null constraint fk_Campeonato_Prova foreign key(ID_Campeonato) references Campeonatos(ID_Campeonato),
ID_Prova int not null constraint fk_Prova_Campeonato foreign key(ID_Prova) references Provas(ID_Prova),
Data_Hora datetime not null
)

create table Nadadores_Provas(
ID_Nadador int not null constraint fk_Nadador_Prova foreign key(ID_Nadador) references Nadadores(ID_Nadador),
ID_Treinador int not null constraint fk_Treinador_Prova foreign key(ID_Treinador) references Treinadores(ID_Treinador),
ID_Equipe int not null constraint fk_Equipe_Prova foreign key(ID_Equipe) references Equipes(ID_Equipe),
ID_Medalha tinyint constraint fk_Medalha_Prova foreign key(ID_Medalha) references Medalhas(ID_Medalha),
ID_Prova_Campeonato int not null constraint fk_Prova_Nadadores foreign key(ID_Prova_Campeonato) references Provas_Campeonatos(ID_Prova_Campeonato)
)