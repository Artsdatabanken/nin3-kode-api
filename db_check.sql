--select Kortkode, Kode from kartleggingsenhet where kortkode is null
select (Select count(distinct(Kortkode)) from kartleggingsenhet) as antall_unik, (Select count() from kartleggingsenhet) as antall_totalt

--select count()