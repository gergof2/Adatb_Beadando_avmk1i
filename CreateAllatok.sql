drop table allatok;

create table allatok
(
	idszam char(4) not null,
	faj varchar2(200) not null,
	nem varchar2(20) not null,
	etkezes varchar2(20) not null,
	ar int not null,
	bolt_id int not null,

	constraint pk_allatok primary key(idszam),
	constraint ch_nem check(nem in ('HIM', 'NOSTENY', 'HIMNOS')),
	constraint ch_etkezes check(etkezes in ('NOVENYEVO', 'HUSEVO', 'MINDENEVO')),
	constraint fk_boltok foreign key(bolt_id) references boltok(id)
);
