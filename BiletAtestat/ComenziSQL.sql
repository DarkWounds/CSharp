--Adaugare film-------------------------
insert into filme(cod, regizor, an, nume, durata) values {1334, 'Amar', 1999, 'Harrys', 350}

--Afisare nr de filme regizat de fiecare regizor-------------------------

--adaug in lista fiecare regizor si dupa r = regizor
select count(*) from filme where regizor = r

--Afis durata maxima a unui film-------------------------
select durata from filme where durata > d
d = durata

--afis la final d

--Afisarea filmelor aparute intr-un anumit an n-------------------------
select nume from filme where an = n

