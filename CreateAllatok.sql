drop table allatok;

create table allatok
(
	idszam int(4) not null,
	faj char(200) not null,
	nem char(20) not null,
	etkezes char(20) not null,
	bolt_id int not null,

	constraint pk_allatok primary key(idszam),
	constraint ch_nem check(nem in ('Nőstény', 'Hím', 'Hímnős')),
	constraint fk_boltok foreign key(bolt_id) references boltok(id)
);
