select distinct(count(kode)) as ant_unik, count(kode) as ant_alle from (
select kode from type
union
select kode from hovedtypegruppe
union
select kode from hovedtype
union
select kode from grunntype
union 
select kode from kartleggingsenhet)