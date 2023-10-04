use CBDA

insert into Equipes(Nome, Cidade_Sede, Data_Fundacao) values('Franca CN', 'Franca', '23/03/1966'), ('Os Phelps de Franca', 'Franca', '10/05/2001'), ('Corinthians', 'Sao Paulo', '27/01/1964'), 
('Flamengo', 'Rio de Janeiro', '24/07/1963')

insert into Pessoas(Numero_Matricula, Nome) values(3627165, 'Arnaldo'), (6891726, 'Alice'), (9187629, 'Ronaldo'), (1785629, 'Murilo'), (5199344, 'Camila'), (3112455, 'Amanda'), 
(5778181, 'Rodrigo'), (1322148, 'Enzo'), (7712353, 'Carlos'), (8891233, 'Aurora'), (1321244, 'Maxine'), (7124822, 'Samuel')

insert into Sexos(Sexo) values('Masculino'), ('Feminino')

insert into Nadadores(ID_Pessoa, ID_Sexo, Data_Inscricao, Email, Data_Nascimento) values (2, 2, '15/08/1994 15:00', 'alice@email.com', '10/05/1976'), (1, 1, '20/04/2005 10:30', 'arnaldo@email.com', '23/01/1980'),
(3, 1, '09/10/1995 12:20', 'ronaldo@email.com', '10/07/1975'), (4, 1, '15/04/2005', 'murilo@emai.com', '05/05/1085'), (5, 2, '11/03/2010 15:34', 'camila@email.com', '28/09/1992'), 
(10, 2, '11/01/2018 17:52', 'aurora@email.com', '10/09/2000'), (11, 2, '28/03/2018 18:00', 'maxine@email.com', '19/11/1999'), (12, 1, '15/04/2018 14:37', 'samuel@email.com', '19/10/1997')

insert into Treinadores(ID_Pessoa, Formacao_Academica) values (6, 'Educacao Fisica'), (7, 'Educacao Fisica'), (8, 'Educacao Fisica'), (9, 'Educacao Fisica')

insert into Tipos_Telefones(Tipo) values ('Residencial'), ('Celular')

insert into Telefones_Nadadores(ID_Nadador, ID_Tipo_Telefone, Numero) values (1, 2, 995142344), (2, 2, 995244314), (2, 1, 995255256), (3, 1, 998945342), (4, 2, 997149311), (5, 1, 993892324), (6, 2, 992422399),
(7, 1, 992112369), (8, 2, 999842766), (8, 1, 992489933)

insert into Estilos(Nome) values ('Livre'), ('Costas'), ('Peito')

insert into Provas(ID_Sexo, ID_Estilo, Distancia) 
values (1, 1, 50), (2, 1, 50), (1, 1, 100), (2, 1, 100), (1, 1, 200),
	   (1, 2, 50), (2, 2, 50), (1, 2, 100), (2, 2, 100), (1, 2, 200),
       (1, 3, 50), (2, 3, 50), (1, 3, 100), (2, 3, 100), (1, 3, 200)

insert into Estilos(Nome) values('Borboleta')

insert into Estilos(Nome) values('Medley'), ('Revezamento')

insert into Provas(ID_Sexo, ID_Estilo, Distancia) values (1, 4, 50), (1, 4, 100), (1, 4, 200), (2, 4, 50), (2, 4, 100)

insert into Campeonatos(Nome, Cidade, Ano_Edicao, Data_Inicio, Data_Termino) values ('Campeonato SP Primeira Edicao', 'São Paulo', 1995, '28/10/1995', '25/11/1995'),
('Campeonato de Fraca', 'Franca', 2005, '21/10/2005', '15/11/2005'), ('Campeonato Carioca', 'Rio de Janeiro', 2010, '31/10/2010', '28/11/2010'), ('Franca Segunda Edicao', 'Franca', 2020, '30/10/2020', '02/12/2020')

select * from Provas_Campeonatos

insert into Provas_Campeonatos(ID_Campeonato, ID_Prova, Data_Hora) values 
(2, 1, '28/10/1995 16:00'), (2, 6, '10/11/1995 14:00'), (2, 3, '10/11/1995 17:00'), (2, 4, '25/11/1995 16:00'),
(3, 2, '21/10/2005 16:00'), (3, 5, '08/11/2005 14:00'), (3, 6, '08/11/2005 17:00'), (3, 7, '15/11/2005 16:00'),
(4, 8, '31/10/2010 16:00'), (4, 9, '15/11/2010 14:00'), (4, 10, '15/11/2010 17:00'), (4, 11, '28/11/2010 16:00'),
(5, 12, '30/10/2020 16:00'), (5, 13, '20/11/2020 14:00'), (5, 14, '20/11/2020 17:00'), (5, 15, '02/12/2020 16:00')

insert into Medalhas(Tipo) values ('Ouro'), ('Prata'), ('Bronze')

insert into Nadadores_Provas(ID_Nadador, ID_Treinador, ID_Equipe, ID_Medalha, ID_Prova_Campeonato) values
(1, 1, 1, 2, 4), (5, 4, 4, null, 4), (6, 1, 1, 1, 4), (7, 2, 2, 3, 4),
(1, 1, 1, 1, 5), (5, 4, 4, null, 5), (6, 1, 1, 3, 5), (7, 2, 2, 2, 5),
(1, 1, 1, 3, 8), (5, 4, 4, 2, 8), (7, 2, 2, 1, 8),
(5, 4, 4, 1, 10), (6, 1, 1, 2, 10), (7, 2, 2, 3, 10),
(1, 1, 1, null, 13), (5, 4, 4, 2, 13), (6, 1, 1, 3, 13), (7, 2, 2, 1, 13),
(1, 1, 1, 2, 15), (6, 1, 1, 1, 15), (7, 2, 2, 3, 15),
(2, 2, 2, 1, 1), (4, 3, 3, 3, 1), (8, 3, 3, 2, 1),
(2, 2, 2, 3, 2), (3, 1, 1, 1, 2), (8, 3, 3, 2, 2),
(2, 2, 2, null, 3), (3, 1 ,1, 2, 3), (4, 3, 3, 3, 3), (8, 3, 3, 1, 3),
(2, 2, 2, 3, 6), (3, 1, 1, 1, 6), (4, 3, 3, null, 6), (8, 3, 3, 2, 6),
(2, 2, 2, 2, 7), (3, 1, 1, 3, 7), (4, 3, 3, 1, 7), (8, 3, 3, null, 7),
(2, 2, 2, 1, 9), (3, 1, 1, 3, 9), (4, 3, 3, 2, 9),
(2, 2, 2, 2, 11), (3, 1, 1, null, 11), (4, 3, 3, 1, 11), (8, 3, 3, 3, 11),
(2, 2, 2, 3, 12), (3, 1, 1, null, 12), (4, 3, 3, 2, 12), (8, 3, 3, 1, 12),
(3, 1, 1, 2, 14), (4, 3, 3, 1, 14), (8, 3, 3, 3, 14),
(3, 1, 1, 1, 16), (4, 3, 3, 2, 16), (8, 3, 3, 3, 16)

insert into Recordes(ID_Nadador, ID_Prova, Data, Tempo) values
(2, 1, '28/10/1995', 160),
(1, 2, '28/10/1995', 140),
(8, 3, '28/10/1995', 100),
(6, 4, '28/10/1995', 120),
(3, 5, '28/10/1995', 130),
(3, 6, '08/11/2005', 160),
(7, 7, '08/11/2005', 170),
(2, 8, '08/11/2005', 134),
(5, 9, '08/11/2005', 142),
(4, 10, '08/11/2005', 121),
(8, 11, '15/11/2010', 137),
(7, 12, '15/11/2010', 154),
(4, 13, '15/11/2010', 142),
(6, 14, '02/12/2020', 123),
(3, 15, '02/12/2020', 104)

select N.ID_Nadador as ID, P.Nome, P.Numero_Matricula, N.Data_Inscricao, N.Data_Nascimento, N.Email, N.Numero_Campeonato from Nadadores as N inner join Pessoas as P on P.ID_Pessoa = N.ID_Pessoa

select T.ID_Treinador as ID, P.Nome, P.Numero_Matricula, T.Formacao_Academica from Treinadores as T inner join Pessoas as P on P.ID_Pessoa = T.ID_Pessoa

select Pessoas.Nome from Nadadores inner join Pessoas on Nadadores.ID_Pessoa = Pessoas.ID_Pessoa where Nome like 'A%'

select * from Pessoas where Numero_Matricula = 1321244

select P.Nome, P.Numero_Matricula, N.Data_Inscricao from Nadadores as N inner join Pessoas as P on P.ID_Pessoa = N.ID_Pessoa where N.Data_Inscricao > '10/10/1995 23:59'

select P.Nome, P.Numero_Matricula, N.Email from Nadadores as N inner join Pessoas as P on P.ID_Pessoa = N.ID_Pessoa where N.Email = 'aurora@email.com'

select P.Nome, P.Numero_Matricula, T.Numero from Nadadores as N inner join Pessoas as P on P.ID_Pessoa = N.ID_Pessoa inner join Telefones_Nadadores as T on N.ID_Nadador = T.ID_Nadador where T.Numero = 992112369

select top(3) with ties Resultado.Treinador, count(Resultado.Medalhas) as Total from (select P.Nome as Treinador, NP.ID_Medalha as Medalhas from Treinadores as T inner join Pessoas as P on P.ID_Pessoa = T.ID_Pessoa 
inner join Nadadores_Provas as NP on NP.ID_Treinador = T.ID_Treinador where NP.ID_Medalha = 1) 
as Resultado group by Resultado.Treinador order by Total desc

select P.Nome, P.Numero_Matricula, E.Nome from Pessoas as P inner join Nadadores as N on P.ID_Pessoa = N.ID_Pessoa inner join Equipes as E on P.ID_Equipe = E.ID_Equipe where P.ID_Equipe = 1

select top(1) with ties Resultado.Equipe, count(Resultado.Nome) as Quantidade_Nadador from (select E.Nome as Equipe, P.Nome from Equipes as E inner join Pessoas as P on P.ID_Equipe = E.ID_Equipe 
inner join Nadadores as N on N.ID_Pessoa = P.ID_Pessoa) as Resultado group by Resultado.Equipe order by Quantidade_Nadador desc

declare @Numero_Equipes int
declare @Contador int

set @Contador = 1
set @Numero_Equipes = (select count(*) from Equipes)

while @Contador <= @Numero_Equipes
	begin
		if @Contador < 2
			if (select Cidade_Sede from Equipes where ID_Equipe = @Contador) = (select Cidade_Sede from Equipes where ID_Equipe = 2)
				select P.Nome, E.Nome, E.Cidade_Sede from Nadadores as N inner join Pessoas as P on P.ID_Pessoa = N.ID_Pessoa inner join Equipes
				as E on E.ID_Equipe = P.ID_Equipe where E.ID_Equipe = @Contador or E.ID_Equipe = 2
		if @Contador < 3
			if (select Cidade_Sede from Equipes where ID_Equipe = @Contador) = (select Cidade_Sede from Equipes where ID_Equipe = 3)
				select P.Nome, E.Nome, E.Cidade_Sede from Nadadores as N inner join Pessoas as P on P.ID_Pessoa = N.ID_Pessoa inner join Equipes as E 
				on E.ID_Equipe = P.ID_Equipe where E.ID_Equipe = @Contador or E.ID_Equipe = 3
		if @Contador < 4
			if (select Cidade_Sede from Equipes where ID_Equipe = @Contador) = (select Cidade_Sede from Equipes where ID_Equipe = 4)
				select P.Nome, E.Nome, E.Cidade_Sede from Nadadores as N inner join Pessoas as P on P.ID_Pessoa = N.ID_Pessoa inner join Equipes  as E 
				on E.ID_Equipe = P.ID_Equipe where E.ID_Equipe = @Contador or E.ID_Equipe = 4
		set @Contador = @Contador + 1
	end;


select P.Distancia as Metros, E.Nome, S.Sexo from Provas as P inner join Estilos as E on P.ID_Estilo = E.ID_Estilo inner join Sexos as S on S.ID_Sexo = P.ID_Sexo

select P.Distancia as Metros, E.Nome, S.Sexo from Provas as P inner join Estilos as E on P.ID_Estilo = E.ID_Estilo inner join Sexos as S on S.ID_Sexo = P.ID_Sexo order by Metros desc

select P.Distancia as Metros, E.Nome, S.Sexo from Provas as P inner join Estilos as E on P.ID_Estilo = E.ID_Estilo inner join Sexos as S on S.ID_Sexo = P.ID_Sexo where P.ID_Estilo = 4 order by Metros desc

select Nome, Cidade, Data_Inicio, Data_Termino from Campeonatos where Cidade = 'Franca' and Data_Inicio between '01/01/2020' and '15/08/2021' or Data_Termino between '01/01/2020' and '15/08/2021' 

select P.Nome, Pr.Distancia as Metros, E.Nome, S.Sexo, R.Data, R.Tempo from Recordes as R inner join Nadadores as N on N.ID_Nadador = R.ID_Nadador inner join Pessoas as P on P.ID_Pessoa = N.ID_Pessoa 
inner join Provas as Pr on Pr.ID_Prova = R.ID_Prova inner join Estilos as E on E.ID_Estilo = Pr.ID_Estilo inner join Sexos as S on S.ID_Sexo = Pr.ID_Sexo

select C.Nome, Pr.Distancia, E.Nome, S.Sexo, C.Cidade, count(NP.ID_Nadador) as QuantidadeParticipante from Provas as Pr inner join Estilos as E on E.ID_Estilo = Pr.ID_Estilo inner join
Sexos as S on S.ID_Sexo = Pr.ID_Sexo inner join Provas_Campeonatos as PC on PC.ID_Prova = Pr.ID_Prova inner join Campeonatos as C on C.ID_Campeonato = PC.ID_Campeonato
inner join Nadadores_Provas as NP on NP.ID_Prova_Campeonato = PC.ID_Prova_Campeonato
where datepart(hour, PC.Data_Hora) between 14 and 16 group by C.Nome, Pr.Distancia, E.Nome, S.Sexo, C.Cidade

select Resultado.ID_Prova_Campeonato, count(Resultado.ID_Nadador_Equipe) as Quantidade_Participante from (select PC.ID_Prova_Campeonato, NP.ID_Nadador_Equipe from Provas as Pr inner join Provas_Campeonatos as PC on PC.ID_Prova = Pr.ID_Prova 
inner join Estilos as E on E.ID_Estilo = Pr.ID_Estilo inner join Sexos as S on S.ID_Sexo = Pr.ID_Sexo inner join Campeonatos as C on C.ID_Campeonato = PC.ID_Campeonato 
inner join Nadadores_Provas as NP on NP.ID_Prova_Campeonato = PC.ID_Prova_Campeonato where datepart(hour, PC.Data_Hora) between 14 and 16) as Resultado group by Resultado.ID_Prova_Campeonato

create view MedalhaOuro 
as select Nadadores.ID_Nadador, Pessoas.Nome, Medalhas.ID_Medalha from Pessoas inner join Nadadores on Nadadores.ID_Pessoa = Pessoas.ID_Pessoa 
inner join Nadadores_Provas on Nadadores.ID_Nadador = Nadadores_Provas.ID_Nadador inner join Medalhas on Medalhas.ID_Medalha = Nadadores_Provas.ID_Medalha where Nadadores_Provas.ID_Medalha = 1

create view MedalhaPrata
as select Nadadores.ID_Nadador, Pessoas.Nome, Medalhas.ID_Medalha from Pessoas inner join Nadadores on Nadadores.ID_Pessoa = Pessoas.ID_Pessoa 
inner join Nadadores_Provas on Nadadores.ID_Nadador = Nadadores_Provas.ID_Nadador inner join Medalhas on Medalhas.ID_Medalha = Nadadores_Provas.ID_Medalha where Nadadores_Provas.ID_Medalha = 2

select MedalhaOuro.Nome from MedalhaOuro inner join MedalhaPrata on MedalhaOuro.ID_Nadador = MedalhaPrata.ID_Nadador group by MedalhaOuro.Nome