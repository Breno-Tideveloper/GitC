select c.MODELO, COUNT(*) as qtd, year(l.DATAINICIO) as 'Ano'

from lOCACAO l
inner join carros c on c.Id = l.CODIGOVEICULO

group by c.MODELO, year(l.DATAINICIO)
order by year(l.DATAINICIO)