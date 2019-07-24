--select * 
--from Marcas m 

--where m.UsuInc = (select u.id from Usuarios u
--                  where u.Usuario like 'Felipe');



--1
select * from Marcas where UsuInc = 2

--2
select count(*) as 'Quantidade'
from marcas m
where m.UsuInc = 1
order by 'Quantidade' desc;

--3

select count(*) as 'Quantidade'
from marcas m
where m.UsuInc = 2
order by 'Quantidade' asc;




--5


select count(*) as 'Quantidade'
from marcas m
where m.UsuInc = 2 

	
--6
select * from Carros where UsuInc = 1

--7
select * from Carros where UsuInc = 2

--8
select count(*) as 'Quantidade'
from marcas m
where m.UsuInc = 1
order by 'Quantidade' asc;

--9
select count(*) as 'Quantidade'
from marcas m
where m.UsuInc = 2
order by 'Quantidade' asc;

--10


--11
--select * from Carros WHERE UsuInc = 1

-- 12
select * from Carros WHERE UsuInc = 2

--13

select m.nome, COUNT(*) as 'qtde'
from  Marcas m
inner join carros c on c.Marca = m.Id
where m.UsuInc = 1
group by m.Nome

--14


select m.nome, COUNT(*) as 'qtde'
from  Marcas m
inner join carros c on c.Marca = m.Id
where m.UsuInc = 2
group by m.Nome

--15

select YEAR(v.datInc) as 'ano', SUM(v.Quantidade)
from vendas v
where year(v.datInc)=2019
group by YEAR(v.datInc)

--16

select YEAR(v.datInc) as 'ano', SUM(v.Quantidade) as 'qtde' --apelido
from vendas v --tabela vendas
where YEAR(v.datInc)=2019
group by YEAR(v.datInc)

--17

select YEAR(v.datInc) as 'ano', SUM(v.Valor) as 'valortotal'
from vendas v --tabela vendas
--ere YEAR(v.datInc)=2019
group by YEAR(v.datInc)

--18

select YEAR(v.datInc) as 'ano', SUM(v.Valor) as 'qtde' --apelido
from vendas v --tabela vendas
--where YEAR(v.datInc)=2019
group by YEAR(v.datInc)

--19

select YEAR(v.datInc) as 'ano', MONTH(v.datInc) as 'mes',  SUM(v.Quantidade) as 'qtde'
from vendas v
group by month(v.datInc), YEAR(v.datInc)
order by 'qtde'  desc;

--20

--21

select YEAR(v.datInc) as 'ano', MONTH(v.datInc) as 'mes',  SUM(v.Valor) as 'valor'
from vendas v
group by month(v.datInc), YEAR(v.datInc)
order by 'valor'  desc;

--22

select (v.UsuInc) as 'usuario', SUM(v.Valor) as 'valor'
from vendas v
where (v.UsuInc)=1
group by(v.UsuInc)

--23

select (v.UsuInc) as 'usuario', SUM(v.Valor) as 'valor'
from vendas v
where (v.UsuInc)=2
group by(v.UsuInc)

--24

select (v.UsuInc) as 'usuario', SUM(v.Quantidade) as 'qtde' --apelido
from vendas v --tabela vendas
where (v.UsuInc)=1
group by (v.UsuInc)

--25

select (v.UsuInc) as 'usuario', SUM(v.Quantidade) as 'qtde' --apelido
from vendas v --tabela vendas
where (v.UsuInc)=2
group by (v.UsuInc)

--28

select m.nome, SUM(v.valor) as 'qtde'
from Vendas v
inner join Carros c on v.Carro = c.Id
inner join Marcas m on c.marca = m.Id
group by m.Nome
order by [qtde] desc

--26

select u.Usuario, SUM(v.quantidade) as 'qtde'
from Vendas v
inner join Usuarios u on v.UsuInc = u.Id
group by Usuario 

--27

select u.Usuario, SUM(v.Valor) as 'R$ total'
 from vendas v
 inner join Usuarios u on v.UsuInc = u.Id
 group by Usuario
 order by [R$ total] asc;

 --29

 select m.Nome,  YEAR(v.datInc) as 'ano', SUM(v.Valor) as 'valor'
from vendas v
 inner join Carros c on v.Carro = c.Id
  inner join Marcas m on m.Id= c.Marca
group by YEAR(v.datInc), m.Nome

--30

select YEAR(v.datInc) as 'ano', SUM(v.Valor) as 'valor', (v.Quantidade) as 'qtde'
from vendas v
group by YEAR(v.datInc), (v.Valor), (v.Quantidade)
order by [qtde], [valor] desc;
