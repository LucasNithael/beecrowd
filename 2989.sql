with salario_func as (
   SELECT d.nome as departamento, di.nome as divisao,  a.salario 
  FROM(   
   	SELECT venc_func.matr, coalesce(venc_func.valor, 0) - coalesce(desc_func.valor, 0) as salario
    From (
      select e.matr, Sum(v.valor) as valor from Empregado e
      left join Emp_venc ev on e.matr = ev.matr
      left join Vencimento v on ev.cod_venc = v.cod_venc
      GROUP by e.matr
    ) as venc_func
    JOIN (
    select e.matr, Sum(d.valor) as valor from Empregado e
    left join Emp_desc ed on e.matr = ed.matr
    left join Desconto d on ed.cod_desc = d.cod_desc
    GROUP by e.matr) as desc_func
     on venc_func.matr = desc_func.matr
   
   ) as a
   
  
  join Empregado e on e.matr = a.matr
  join Divisao di on di.cod_divisao = e.lotacao_div
  join Departamento d on d.cod_dep = di.cod_dep
)

select sf.departamento, sf.divisao, round(avg(sf.salario), 2) as media, round(max(sf.salario), 2) as maior
from salario_func sf
GROUP by sf.departamento, sf.divisao 
order by  media desc
