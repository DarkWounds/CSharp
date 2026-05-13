--Adaugare de noi persoane:

insert into persoane (cnp, nume, prenume, seria) values {'50003243404', 'Barak', 'Obama', 'WD-2342'}

--Afisarea persoanelor cu numele popescu

select nume, prenume from persoane where nume = 'Popescu'

--Numarul de pers de sex masculin

select count(*) from persoane where cnp like '1%' or '5%'

--Numarul pers cu finalul preumelui 'ela'

select count(*) from persoane where prenume like '%ela' 
select count(*) from persoane where right(prenume, 3) = 'ela'